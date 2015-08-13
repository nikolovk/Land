(function () {
    'use strict';

    angular.module('app.services')
    .factory('OwnersService', OwnersService);

    OwnersService.$inject = ['$http', 'exception', 'logger'];

    function OwnersService($http, exception, logger) {
        var service = {
            getOwners:getOwners,
            createOwner:createOwner,
            updateOwner:updateOwner
        };
        return service;

        ///////////////

        function getOwners(){
            return $http.get('http://localhost:9999/api/owners')
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
        
        function createOwner(owner){
            return $http.post('http://localhost:9999/api/owners',owner)
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
        
        function updateOwner(owner){
            return $http.put('http://localhost:9999/api/owners',owner)
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
    }
})();
