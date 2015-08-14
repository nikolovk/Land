(function () {
    'use strict';

    angular.module('app.modules.mortgages')
    .controller('LandPropertiesController', LandPropertiesController);

    LandPropertiesController.$inject = ['$modal', 'LandPropertiesService', 'mortgagesService', 'OwnersService'];
    function LandPropertiesController($modal, landPropertiesService, mortgagesService, ownersService) {
        //TODO load data on route resolve
        var vm = this;
        vm.openModal = openModal;
        vm.openMortageModal = openMortageModal;
        landPropertiesService.getLandProperties()
        .then(function (landProperties) {
            vm.landProperties = landProperties;
        });
        loadMortages();
        loadOwners();

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
                    },
                    ownersDictionary: function () {
                        return vm.ownersDictionary;
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

        function loadOwners() {
            ownersService.getOwners()
                        .then(function (owners) {
                            vm.owners = owners;
                            vm.ownersDictionary = {};
                            for (var i = 0; i < owners.length; i++) {
                                vm.ownersDictionary[owners[i].ownerID] = owners[i];
                            }
                        });
        }
    }
})();
