(function () {
    //获取服务层方法
    var _categoryService = abp.services.app.category;
    var _$catelgoryInformationForm = $(".catelgory").find('form[name=Catelgoryfrom]');
    var addPer = abp.auth.hasPermission("Pages.Category.CreateCategory")
    var _modalManager;
    app.modals.CreateOrEditModal = function () {
        this.init = function (modalManager) {
            _modalManager = modalManager;
        };
        this.save = function () {
            var catelgory = _$catelgoryInformationForm.serializeFormToObject();
            if (addPer) {
                if (!_$catelgoryInformationForm.valid()) {
                    return;
                }
                _categoryService.createOrUpdateCategoryAsync({
                    categoryEditDto: catelgory
                }).done(function () {
                    abp.notify.info(app.localize('SavedSuccessfully'));
                    _modalManager.close();
                    _$SendOrdersTable.bootstrapTable('refresh')

                });


            }
            else {
                alert("没有相应的权限，请与管理员取得联系！", "", "error")
            }
        }
    };
   
   
})();

