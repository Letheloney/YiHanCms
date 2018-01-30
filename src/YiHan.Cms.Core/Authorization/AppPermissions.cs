namespace YiHan.Cms.Authorization
{
    /// <summary>
    /// Defines string constants for application's permission names.
    /// <see cref="AppAuthorizationProvider"/> for permission definitions.
    /// </summary>
    public static class AppPermissions
    {
        //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

        public const string Pages = "Pages";
        
        public const string Pages_Administration = "Pages.Administration";

        public const string Pages_Administration_Roles = "Pages.Administration.Roles";
        public const string Pages_Administration_Roles_Create = "Pages.Administration.Roles.Create";
        public const string Pages_Administration_Roles_Edit = "Pages.Administration.Roles.Edit";
        public const string Pages_Administration_Roles_Delete = "Pages.Administration.Roles.Delete";

        public const string Pages_Administration_Users = "Pages.Administration.Users";
        public const string Pages_Administration_Users_Create = "Pages.Administration.Users.Create";
        public const string Pages_Administration_Users_Edit = "Pages.Administration.Users.Edit";
        public const string Pages_Administration_Users_Delete = "Pages.Administration.Users.Delete";
        public const string Pages_Administration_Users_ChangePermissions = "Pages.Administration.Users.ChangePermissions";
        public const string Pages_Administration_Users_Impersonation = "Pages.Administration.Users.Impersonation";

        public const string Pages_Administration_Languages = "Pages.Administration.Languages";
        public const string Pages_Administration_Languages_Create = "Pages.Administration.Languages.Create";
        public const string Pages_Administration_Languages_Edit = "Pages.Administration.Languages.Edit";
        public const string Pages_Administration_Languages_Delete = "Pages.Administration.Languages.Delete";
        public const string Pages_Administration_Languages_ChangeTexts = "Pages.Administration.Languages.ChangeTexts";

        public const string Pages_Administration_AuditLogs = "Pages.Administration.AuditLogs";

        public const string Pages_Administration_OrganizationUnits = "Pages.Administration.OrganizationUnits";
        public const string Pages_Administration_OrganizationUnits_ManageOrganizationTree = "Pages.Administration.OrganizationUnits.ManageOrganizationTree";
        public const string Pages_Administration_OrganizationUnits_ManageMembers = "Pages.Administration.OrganizationUnits.ManageMembers";

        public const string Pages_Administration_HangfireDashboard = "Pages.Administration.HangfireDashboard";

        //TENANT-SPECIFIC PERMISSIONS

        public const string Pages_Tenant_Dashboard = "Pages.Tenant.Dashboard";

        public const string Pages_Administration_Tenant_Settings = "Pages.Administration.Tenant.Settings";
        
        //HOST-SPECIFIC PERMISSIONS

        public const string Pages_Editions = "Pages.Editions";
        public const string Pages_Editions_Create = "Pages.Editions.Create";
        public const string Pages_Editions_Edit = "Pages.Editions.Edit";
        public const string Pages_Editions_Delete = "Pages.Editions.Delete";

        public const string Pages_Tenants = "Pages.Tenants";
        public const string Pages_Tenants_Create = "Pages.Tenants.Create";
        public const string Pages_Tenants_Edit = "Pages.Tenants.Edit";
        public const string Pages_Tenants_ChangeFeatures = "Pages.Tenants.ChangeFeatures";
        public const string Pages_Tenants_Delete = "Pages.Tenants.Delete";
        public const string Pages_Tenants_Impersonation = "Pages.Tenants.Impersonation";

        public const string Pages_Administration_Host_Maintenance = "Pages.Administration.Host.Maintenance";
        public const string Pages_Administration_Host_Settings = "Pages.Administration.Host.Settings";

        /// <summary>
        /// ����������Ȩ��
        /// </summary>
        public const string Category = "Pages.Category";



        /// <summary>
        /// ����������Ȩ��
        /// </summary>
        public const string Category_CreateCategory = "Pages.Category.CreateCategory";
        /// <summary>
        /// ��������޸�Ȩ��
        /// </summary>
        public const string Category_EditCategory = "Pages.Category.EditCategory";
        /// <summary>
        /// �������ɾ��Ȩ��
        /// </summary>
        public const string Category_DeleteCategory = "Pages.Category.DeleteCategory";
        /// <summary>
        /// ���¹������Ȩ��
        /// </summary>
        public const string Artice = "Pages.Artice";



        /// <summary>
        /// ���¹������Ȩ��
        /// </summary>
        public const string Artice_CreateArtice = "Pages.Artice.CreateArtice";
        /// <summary>
        /// ���¹����޸�Ȩ��
        /// </summary>
        public const string Artice_EditArtice = "Pages.Artice.EditArtice";
        /// <summary>
        /// ���¹���ɾ��Ȩ��
        /// </summary>
        public const string Artice_DeleteArtice = "Pages.Artice.DeleteArtice";
        /// <summary>
        /// ͼƬ�������Ȩ��
        /// </summary>
        public const string ImgCategory = "Pages.ImgCategory";



        /// <summary>
        /// ͼƬ���ഴ��Ȩ��
        /// </summary>
        public const string ImgCategory_CreateImgCategory = "Pages.ImgCategory.CreateImgCategory";
        /// <summary>
        /// ͼƬ�����޸�Ȩ��
        /// </summary>
        public const string ImgCategory_EditImgCategory = "Pages.ImgCategory.EditImgCategory";
        /// <summary>
        /// ͼƬ����ɾ��Ȩ��
        /// </summary>
        public const string ImgCategory_DeleteImgCategory = "Pages.ImgCategory.DeleteImgCategory";

        /// <summary>
        /// ͼ��������Ȩ��
        /// </summary>
        public const string ImGallery = "Pages.ImGallery";



        /// <summary>
        /// ͼ��������Ȩ��
        /// </summary>
        public const string ImGallery_CreateImGallery = "Pages.ImGallery.CreateImGallery";
        /// <summary>
        /// ͼ������޸�Ȩ��
        /// </summary>
        public const string ImGallery_EditImGallery = "Pages.ImGallery.EditImGallery";
        /// <summary>
        /// ͼ�����ɾ��Ȩ��
        /// </summary>
        public const string ImGallery_DeleteImGallery = "Pages.ImGallery.DeleteImGallery";
        /// <summary>
        /// ϵͳ���ù���Ȩ��
        /// </summary>
        public const string SysSetting = "Pages.SysSetting";



        /// <summary>
        /// ϵͳ���ô���Ȩ��
        /// </summary>
        public const string SysSetting_CreateSysSetting = "Pages.SysSetting.CreateSysSetting";
        /// <summary>
        /// ϵͳ�����޸�Ȩ��
        /// </summary>
        public const string SysSetting_EditSysSetting = "Pages.SysSetting.EditSysSetting";
        /// <summary>
        /// ϵͳ����ɾ��Ȩ��
        /// </summary>
        public const string SysSetting_DeleteSysSetting = "Pages.SysSetting.DeleteSysSetting";


        public const string TempSystem = "Pages.TempSystem";
    }
}