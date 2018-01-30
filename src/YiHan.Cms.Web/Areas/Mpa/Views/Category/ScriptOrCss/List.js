//选取界面上要先数据的表格
var _$SendOrdersTable = $('#detail-grid');
//获取服务层方法
var _categoryService = abp.services.app.category;
var del = abp.auth.hasPermission("Pages.Category.DeleteCategory")
var Edit = abp.auth.hasPermission("Pages.Category.EditCategory")
var _createModal = new app.ModalManager({
    viewUrl: abp.appPath + 'Mpa/Category/CreateOrEditModal',
    scriptUrl: abp.appPath + 'Areas/Mpa/Views/Category/ScriptOrCss/_CreateOrEditModal.js',
    modalClass: 'CreateOrEditModal'
});
_$SendOrdersTable.bootstrapTable({
    url: "/Mpa/Category/CategorysList",
    method:"post",
    detailView: false,
    search: false,
    striped: true,
    pagination: false,
    sidePagination: 'server',
    treeView: true,
    treeId: "Id",
    treeRootLevel: 0,
    treeField: "Category_Name",
    clickToSelect: true,
    uniqueId: 'Id',
    methodParams: {

        Name: $("#search_Name").val(),
        status: $("#search_status").val()

    },
    columns: [
    {
        field: app.localize('Category_Name'),
        title: '分类名称'
     },
    {
        field: app.localize('Id'),
        title: 'Id'
    },
    {
        field: app.localize('Rank'),
        title: '排序',
        editable: {
            type: 'text',
            title: '排序',
            validate: function (v) {
                if (!v) return '排序为空';

            }
        }
    },
    {
        field: app.localize('Status'),
        title: '是否显示'
    },
    {
        field: app.localize('Button'),
        title: '操作',
        formatter: addfunction

    },
    ],
    onEditableSave: function (field, row, oldValue, $el) {
        $.ajax({
            type: "post",
            url: "/Category/UdateCol",
            data: row,
            dataType: 'JSON',
            success: function (data, status) {
                if (status == "success") {
                    swal('提交数据成功', "", "success");
                }
            },
            error: function () {
                alert('编辑失败', "", "error");
            },
            complete: function () {

            }

        });
    }

});
function addfunction(value, row, index) {
    return [
        ' <a href="###" data_index=' + index + ' class="btn btn-primary blue edit"><i class="fa fa-plus"></i> 编辑</a>',
        ' <a href="###" data_index=' + index + ' class="btn btn-primary blue delete"><i class="fa fa-plus"></i> 删除</a>'
    ].join("")
}
$("#detail-grid").on("click", ".edit", function () {
    if (Edit) {
        var _eidtModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Mpa/Category/CreateOrEditModal?Id=' + $(this).parent().parent().attr("data-uniqueid") + '',
            scriptUrl: abp.appPath + 'Areas/Mpa/Views/Category/ScriptOrCss/_CreateOrEditModal.js',
            modalClass: 'CreateOrEditModal'
        });
        _eidtModal.open();
    }
    else
    {
        swal("没有相应的权限，请与管理员取得联系！", "", "error")
    }
  
})
$("#detail-grid").on("click", ".delete", function () {
    var id = $(this).parent().parent().attr("data-uniqueid")
    if (del) {
        abp.message.confirm(
            "是否删除当前行程,请慎重，删除后不可恢复，如无必要，请下架处理即可！",
            function (isConfirmed) {
                if (isConfirmed) {
                    _categoryService.deleteCategoryAsync({
                        id: id
                    }).done(function () {
                        abp.notify.info(app.localize('SavedSuccessfully'));
                        _$SendOrdersTable.bootstrapTable('refresh')
                    });
                }
            }
        );
    }
    else {
        swal("没有相应的权限，请与管理员取得联系！", "", "error")
    }

})
$("#search").click(function () {
    _$SendOrdersTable.bootstrapTable('refresh', {
        query: {
            Name: $("#search_Name").val(),
            Status: $("#search_status").val()
           
        }
    });
})
$(".openModel").click(function () {
    _createModal.open();
})