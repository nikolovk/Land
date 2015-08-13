(function () {
    'use strict';

    angular.module('app.services')
    .factory('LandPropertiesService', LandPropertiesService);

    LandPropertiesService.$inject = ['$http', 'exception', 'logger'];

    function LandPropertiesService($http, exception, logger) {
        var service = {
            getLandProperties:getLandProperties,
            createLandProperty:createLandProperty,
            updateLandProperty:updateLandProperty
        };
        return service;

        ///////////////

        function getLandProperties(){
            return $http.get('http://localhost:9999/api/landProperties')
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
        
        function createLandProperty(landProperty){
            return $http.post('http://localhost:9999/api/landProperties',landProperty)
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
        
        function updateLandProperty(landProperty){
            return $http.put('http://localhost:9999/api/landProperties',landProperty)
            .then(function (response) {
                return response.data;
            })
                .catch(function (message) {
                exception.catcher('XHR Failed')(message);
            });
        }
    }
})();
