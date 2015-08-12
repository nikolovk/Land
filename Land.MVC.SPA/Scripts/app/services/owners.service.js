(function () {
    'use strict';

    angular.module('app.services')
    .factory('OwnersService', OwnersService);

    OwnersService.$inject = ['$http'];

    function OwnersService($http) {
        var service = {
            getOwners:getOwners
        };
        return service;

        ///////////////

        function getOwners(){
            return $http.get('http://localhost:9999/api/owners')
            .then(function (response) {
                return response.data;
            });
        }
    }
})();