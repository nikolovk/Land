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
        })
        .when('/mortgages', {
            templateUrl: '/templates/mortgages',
            controller: 'mortgagesController',
            controllerAs: 'vm',
        })
        .when('/landProperties', {
            templateUrl: '/templates/landProperties',
            controller: 'LandPropertiesController',
            controllerAs: 'vm',
        })
        ;
    }
})();