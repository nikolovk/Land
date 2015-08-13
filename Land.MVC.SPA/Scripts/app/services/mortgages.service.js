(function () {
    'use strict';

    angular.module('app.services')
    .factory('mortgagesService', mortgagesService);

    mortgagesService.$inject = ['$http', 'exception', 'logger'];

    function mortgagesService($http, exception, logger) {
        var service = {
            getMortgages:getMortgages,
            createMortgage: createMortgage,
            updateMortgage: updateMortgage
        };
        return service;

        ///////////////

        function getMortgages() {
            return $http.get('http://localhost:9999/api/mortgages')
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
        
        function createMortgage(mortgage){
            return $http.post('http://localhost:9999/api/mortgages',mortgage)
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
        
        function updateMortgage(mortgage){
            return $http.put('http://localhost:9999/api/mortgages',mortgage)
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
    }
})();
