(function () {
    'use strict';

    angular.module('app.modules.mortgages')
    .controller('LandPropertiesController', LandPropertiesController);

    LandPropertiesController.$inject = ['$modal', 'LandPropertiesService', 'mortgagesService'];
    function LandPropertiesController($modal, landPropertiesService, mortgagesService) {
        //TODO load data on route resolve
        var vm = this;
        vm.openModal = openModal;
        vm.openMortageModal = openMortageModal;
        landPropertiesService.getLandProperties()
        .then(function (landProperties) {
            vm.landProperties = landProperties;
        });
        loadMortages();

        //////////////////

        function openModal(landProperty, isNew) {
            landProperty = landProperty || {};
            landProperty.isNew = isNew;
            $modal.open({
                templateUrl: 'templates/landPropertiesModal',
                controller: 'LandPropertyModalController',
                controllerAs: 'vm',
                backdropClass: 'backdrop-fixed',
                resolve: {
                    landProperty: function () {
                        return landProperty;
                    }
                }
            }).result.then(function () {
                landPropertiesService.getLandProperties()
                      .then(function (landProperties) {
                          vm.landProperties = landProperties;
                      });
            });
        }

        function openMortageModal(mortgage, isNew,upi) {
            mortgage = mortgage || {};
            mortgage.isNew = isNew;
            mortgage.upi = upi;
            $modal.open({
                templateUrl: 'templates/mortgagesModal',
                controller: 'MortgageModalController',
                controllerAs: 'vm',
                backdropClass: 'backdrop-fixed',
                resolve: {
                    mortgage: function () {
                        return mortgage;
                    }
                }
            }).result.then(function () {
                loadMortages();
            });
        }

        function loadMortages() {
            mortgagesService.getMortgages()
            .then(function (mortgages) {
                vm.mortgages = mortgages;
                vm.mortagesDictionary = {};
                for (var i = 0; i < mortgages.length; i++) {
                    mortgages[i].date = new Date(mortgages[i].date);
                    vm.mortagesDictionary[mortgages[i].upi] = mortgages[i];
                }
            });
        }
    }
})();
