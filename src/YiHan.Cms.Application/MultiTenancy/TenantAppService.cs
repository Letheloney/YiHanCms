﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using Abp;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Uow;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Abp.Runtime.Security;
using YiHan.Cms.Authorization;
using YiHan.Cms.Authorization.Users;
using YiHan.Cms.Editions.Dto;
using YiHan.Cms.MultiTenancy.Dto;

namespace YiHan.Cms.MultiTenancy
{
    [AbpAuthorize(AppPermissions.Pages_Tenants)]
    public class TenantAppService : CmsAppServiceBase, ITenantAppService
    {
        public async Task<PagedResultDto<TenantListDto>> GetTenants(GetTenantsInput input)
        {
            var query = TenantManager.Tenants
                .Include(t => t.Edition)
                .WhereIf(
                    !input.Filter.IsNullOrWhiteSpace(),
                    t =>
                        t.Name.Contains(input.Filter) ||
                        t.TenancyName.Contains(input.Filter)
                );

            var tenantCount = await query.CountAsync();
            var tenants = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            return new PagedResultDto<TenantListDto>(
                tenantCount,
                tenants.MapTo<List<TenantListDto>>()
                );
        }

        [AbpAuthorize(AppPermissions.Pages_Tenants_Create)]
        [UnitOfWork(IsDisabled = true)]
        public async Task CreateTenant(CreateTenantInput input)
        {
            await TenantManager.CreateWithAdminUserAsync(input.TenancyName,
                input.Name,
                input.AdminPassword,
                input.AdminEmailAddress,
                input.ConnectionString,
                input.IsActive,
                input.EditionId,
                input.ShouldChangePasswordOnNextLogin,
                input.SendActivationEmail);
        }

        [AbpAuthorize(AppPermissions.Pages_Tenants_Edit)]
        public async Task<TenantEditDto> GetTenantForEdit(EntityDto input)
        {
            var tenantEditDto = (await TenantManager.GetByIdAsync(input.Id)).MapTo<TenantEditDto>();
            tenantEditDto.ConnectionString = SimpleStringCipher.Instance.Decrypt(tenantEditDto.ConnectionString);
            return tenantEditDto;
        }

        [AbpAuthorize(AppPermissions.Pages_Tenants_Edit)]
        public async Task UpdateTenant(TenantEditDto input)
        {
            input.ConnectionString = SimpleStringCipher.Instance.Encrypt(input.ConnectionString);
            var tenant = await TenantManager.GetByIdAsync(input.Id);
            input.MapTo(tenant);
            await TenantManager.UpdateAsync(tenant);
        }

        [AbpAuthorize(AppPermissions.Pages_Tenants_Delete)]
        public async Task DeleteTenant(EntityDto input)
        {
            var tenant = await TenantManager.GetByIdAsync(input.Id);
            await TenantManager.DeleteAsync(tenant);
        }

        [AbpAuthorize(AppPermissions.Pages_Tenants_ChangeFeatures)]
        public async Task<GetTenantFeaturesForEditOutput> GetTenantFeaturesForEdit(EntityDto input)
        {
            var features = FeatureManager.GetAll();
            var featureValues = await TenantManager.GetFeatureValuesAsync(input.Id);

            return new GetTenantFeaturesForEditOutput
            {
                Features = features.MapTo<List<FlatFeatureDto>>().OrderBy(f => f.DisplayName).ToList(),
                FeatureValues = featureValues.Select(fv => new NameValueDto(fv)).ToList()
            };
        }

        [AbpAuthorize(AppPermissions.Pages_Tenants_ChangeFeatures)]
        public async Task UpdateTenantFeatures(UpdateTenantFeaturesInput input)
        {
            await TenantManager.SetFeatureValuesAsync(input.Id, input.FeatureValues.Select(fv => new NameValue(fv.Name, fv.Value)).ToArray());
        }

        [AbpAuthorize(AppPermissions.Pages_Tenants_ChangeFeatures)]
        public async Task ResetTenantSpecificFeatures(EntityDto input)
        {
            await TenantManager.ResetAllFeaturesAsync(input.Id);
        }

        public async Task UnlockTenantAdmin(EntityDto input)
        {
            using (CurrentUnitOfWork.SetTenantId(input.Id))
            {
                var tenantAdmin = await UserManager.FindByNameAsync(User.AdminUserName);
                if (tenantAdmin != null)
                {
                    tenantAdmin.Unlock();
                }
            }
        }
    }
}