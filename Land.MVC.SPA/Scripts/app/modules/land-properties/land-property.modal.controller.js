﻿(function () {
    'use strict';

    angular.module('app.modules.owners')
    .controller('LandPropertyModalController', LandPropertyModalController);

    LandPropertyModalController.$inject = ['$modalInstance', 'LandPropertiesService', 'landProperty','ownersDictionary'];
    function LandPropertyModalController($modalInstance, landPropertiesService, landProperty, ownersDictionary) {
        var vm = this;
        vm.landProperty = landProperty;
        vm.ownersDictionary = ownersDictionary;
        vm.save = save;
        vm.cancel = cancel;

        function save() {
            if (vm.landProperty.isNew) {
                landPropertiesService.createLandProperty(vm.landProperty)
                .then(function () {
                    $modalInstance.close();

                });
            } else {
                landPropertiesService.updateLandProperty(vm.landProperty)
                .then(function () {
                    $modalInstance.close();

                });
            }

        }

        function cancel() {
            $modalInstance.dismiss();
        }
    }
})();
