(function ($) {
    'use strict';

    //debugger;
    //通过构造函数获取到bootstrapTable里面的初始化方法
    var BootstrapTable = $.fn.bootstrapTable.Constructor,
        _initData = BootstrapTable.prototype.initData,
        _initPagination = BootstrapTable.prototype.initPagination,
        _initBody = BootstrapTable.prototype.initBody,
        _initServer = BootstrapTable.prototype.initServer,
        _initContainer = BootstrapTable.prototype.initContainer;

    //重写
    BootstrapTable.prototype.initData = function () {
        _initData.apply(this, Array.prototype.slice.apply(arguments));
    };

    BootstrapTable.prototype.initPagination = function () {
        _initPagination.apply(this, Array.prototype.slice.apply(arguments));
    };

    BootstrapTable.prototype.initBody = function (fixedScroll) {
        _initBody.apply(this, Array.prototype.slice.apply(arguments));
    };

    BootstrapTable.prototype.initServer = function (silent, query) {
        //构造自定义参数
        for (var key in this.options.methodParams) {
            $.fn.bootstrapTable.defaults.methodParams[key] = this.options.methodParams[key];
        }
        //如果传了url，则走原来的逻辑
        if (this.options.url) {
            _initServer.apply(this, Array.prototype.slice.apply(arguments));
            return;
        }
        //如果定义了abpMethod，则走abpMethod的逻辑
        if (!this.options.abpMethod) {
            return;
        }
        var that = this,
            data = {},
            params = {
                pageSize: this.options.pageSize === this.options.formatAllRows() ?
                    this.options.totalRows : this.options.pageSize,
                pageNumber: this.options.pageNumber,
                searchText: this.searchText,
                sortName: this.options.sortName,
                sortOrder: this.options.sortOrder
            },
            request;

        
        //debugger;
        if (this.options.queryParamsType === 'limit') {
            params = {
                search: params.searchText,
                sort: params.sortName,
                order: params.sortOrder
            };
            if (this.options.pagination) {
                params.limit = this.options.pageSize === this.options.formatAllRows() ?
                    this.options.totalRows : this.options.pageSize;
                params.offset = this.options.pageSize === this.options.formatAllRows() ?
                    0 : this.options.pageSize * (this.options.pageNumber - 1);
            }
        }

        if (!($.isEmptyObject(this.filterColumnsPartial))) {
            params['filter'] = JSON.stringify(this.filterColumnsPartial, null);
        }

        data = $.fn.bootstrapTable.utils.calculateObjectValue(this.options, this.options.queryParams, [params], data);

        $.extend(data, query || {});

        // false to stop request
        if (data === false) {
            return;
        }

        if (!silent) {
            this.$tableLoading.show();
        }
        
        this.options.abpMethod(data).done(function (result) {
            result = $.fn.bootstrapTable.utils.calculateObjectValue(that.options, that.options.responseHandler, [result], result);
            that.load(result);
            that.trigger('load-success', result);
        });
        request = $.extend({}, $.fn.bootstrapTable.utils.calculateObjectValue(null, this.options.ajaxOptions), {
            type: this.options.method,
            url: this.options.url,
            data: this.options.contentType === 'application/json' && this.options.method === 'post' ?
                JSON.stringify(data) : data,
            cache: this.options.cache,
            contentType: this.options.contentType,
            dataType: this.options.dataType,
            success: function (res) {
                debugger;
                res = $.fn.bootstrapTable.utils.calculateObjectValue(that.options, that.options.responseHandler, [res], res);

                that.load(res);
                that.trigger('load-success', res);
            },
            error: function (res) {
                that.trigger('load-error', res.status, res);
            },
            complete: function () {
                if (!silent) {
                    that.$tableLoading.hide();
                }
            }
        });

        if (this.options.ajax) {
            $.fn.bootstrapTable.utils.calculateObjectValue(this, this.options.ajax, [request], null);
        } else {
            $.ajax(request);
        }
    }

    BootstrapTable.prototype.initContainer = function () {
        _initContainer.apply(this, Array.prototype.slice.apply(arguments));
    };

    abp.bootstrapTableDefaults = {
        striped: false,
        classes: 'table table-striped table-bordered table-advance table-hover',
        
        cache: false,
        sidePagination: 'server',
        uniqueId: 'id',
        cardView: false,
        showRefresh: false,
        search: false,
        method: 'post',
        toolbar: '#toolbar',
        pageSize: 10,
        cardView: false,
        paginationPreText: '上一页',
        paginationNextText: '下一页',
        queryParams: function (param) {
           //$.fn.bootstrapTable.defaults.methodParams.propertyIsEnumerable()
            var abpParam = {
                Sorting: param.sort,
                filter: param.search,
                skipCount: param.offset,
                maxResultCount: param.limit
            };
            for (var key in $.fn.bootstrapTable.defaults.methodParams) {
                abpParam[key] = $.fn.bootstrapTable.defaults.methodParams[key];
            }
            return abpParam;
        },
        responseHandler: function (res) {
            if (res.totalCount)
                return { total: res.totalCount, rows: res.items };
            else if (res.totalCount != undefined)
                return { total: res.totalCount, rows: res.items };
            else
                return {  rows: res };
                
        },
        methodParams: {},
        abpMethod: function () { }
    };
    
    $.extend($.fn.bootstrapTable.defaults, abp.bootstrapTableDefaults);
})(jQuery);