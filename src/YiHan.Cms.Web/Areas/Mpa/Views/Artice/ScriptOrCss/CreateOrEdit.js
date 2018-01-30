$(function () {
    CKEDITOR.replace('Art_Content');

});
var _$ArticeInformationForm = $(".portlet-body").find('form[name=ArticeForm]');;
var _articeService = abp.services.app.artice;
var addPer = abp.auth.hasPermission("Pages.Artice.CreateArtice")
function BrowseServer() {
    var finder = new CKFinder();
    finder.basePath = '<%=request.getContextPath()%>/ckfinder/';
    finder.selectActionFunction = SetFileField; //当选中图片时执行的函数
    finder.popup();//调用窗口       
}
//文件选中时执行
//fileUrl所选中文件的路径
function SetFileField(fileUrl) {
    $(".xFilePath").val(fileUrl);
    $("#Art_CoverUrl").attr("src", fileUrl)
}
$(".saveBtn").click(function () {
    var Artice = _$ArticeInformationForm.serializeFormToObject();
    if (addPer) {
        if (!_$ArticeInformationForm.valid()) {
            return;
        }
        abp.message.confirm(
            "是否需要新增、复制或修改价格",
            function (isConfirmed) {
                if (isConfirmed) {
        _articeService.createOrUpdateArticeAsync({
            articeEditDto: Artice
        }).done(function () {
            abp.notify.info(app.localize('SavedSuccessfully'));

            });
        }
         }
        );

    }
    else {
        alert("没有相应的权限，请与管理员取得联系！", "", "error")
    }
})