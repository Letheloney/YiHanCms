//选取界面上要先数据的表格
var _$SendOrdersTable = $('#detail-grid');
//获取服务层方法
var _ArticeService = abp.services.app.artice;
var del = abp.auth.hasPermission("Pages.Artice.DeleteArtice")
var Edit = abp.auth.hasPermission("Pages.Artice.EditArtice")

_$SendOrdersTable.bootstrapTable({
    abpMethod: _ArticeService.getPagedArticesAsync,
    detailView: false,
    search: false,
    methodParams: {

        Name: $("#search_Name").val(),
        status: $("#search_status").val(),
         ParentId: $("#cateGory").val(),
    },
    columns: [
      
        {
            field: app.localize('id'),
            title: 'Id'
        },
        {
            field: 'art_CoverUrl',
            title: '封面图',
            align: 'center',
            formatter: function (value, row, index) {
                return '<img  src="' + row.art_CoverUrl + '" width=50 class="img-rounded" >';
            }

        },
        {
            field: app.localize('art_Name'),
            title: '文章标题'
        },
        {
            field: app.localize('art_SubName'),
            title: '文章副标题'
        }
        ,
        {
            field: app.localize('category_ID'),
            title: '父级Id'
        },
        {
            field: app.localize('rank'),
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
            field: app.localize('status'),
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
            url: "/Artice/UdateCol",
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
        location.href = "/Mpa/Artice/CreateOrEdit?Id=" + $(this).parent().parent().attr("data-uniqueid") + ""
    }
    else {
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
                    _ArticeService.deleteArticeAsync({
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
            Status: $("#search_status").val(),
            ParentId: $("#cateGory").val(),

        }
    });
})
