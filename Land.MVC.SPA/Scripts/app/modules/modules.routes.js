(function () {
    'use strict';

    angular.module('app.modules').config(config);
    config.$inject = [
    '$routeProvider',
    ];

    function config($routeProvider) {
        $routeProvider.when('/owners', {
            templateUrl: '/templates/owners',
            controller: 'OwnersController',
            controllerAs: 'vm',
        });
    }
})();