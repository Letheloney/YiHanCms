(function () {
    'use strict';
    appModule.directive('autoFocus', ['$timeout',
        function ($timeout) {
            return {
                restrict: 'A',
                link: function ($scope, element) {
                    $timeout(function () {
                        if ($(window).width() > 768) {
                            element[0].focus();
                        }
                    });
                }
            };
        }
    ]);
})();