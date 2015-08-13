(function () {
    'use strict';

    angular.module('app.services')
    .factory('MortagesService', MortagesService);

    MortagesService.$inject = ['$http', 'exception', 'logger'];

    function MortagesService($http, exception, logger) {
        var service = {
            getMortages:getMortages,
            createMortage:createMortage,
            updateMortage:updateMortage
        };
        return service;

        ///////////////

        function getMortages(){
            return $http.get('http://localhost:9999/api/mortages')
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
        
        function createMortage(mortage){
            return $http.post('http://localhost:9999/api/mortages',mortage)
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
        
        function updateMortage(mortage){
            return $http.put('http://localhost:9999/api/mortages',mortage)
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
    }
})();
