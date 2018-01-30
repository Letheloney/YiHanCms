﻿(function () {
    appModule.controller('common.views.layout.footer', [
        '$rootScope', 'appSession',
        function ($scope, appSession) {
            var vm = this;

            $scope.$on('$includeContentLoaded', function () {
                Layout.initFooter(); // init footer
            });

            vm.getProductNameWithEdition = function() {
                var productName = 'Cms';
                if (appSession.tenant && appSession.tenant.editionDisplayName) {
                    productName = productName + ' ' + appSession.tenant.editionDisplayName;
                }

                return productName;
            }
        }
    ]);
})();