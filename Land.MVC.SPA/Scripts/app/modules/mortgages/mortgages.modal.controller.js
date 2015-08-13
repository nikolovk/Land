(function () {
    'use strict';

    angular.module('app.modules.mortgages')
    .controller('MortgageModalController', MortgageModalController);

    MortgageModalController.$inject = ['$modalInstance', 'mortgagesService', 'mortgage'];
    function MortgageModalController($modalInstance, mortgagesService, mortgage) {
        var vm = this;
        vm.mortgage = mortgage;
        vm.save = save;
        vm.cancel = cancel;

        /////////////////

        function save() {
            if (mortgage.isNew) {
                mortgagesService.createMortgage(mortgage)
                .then(function () {
                    $modalInstance.close();

                });
            } else {
                mortgagesService.updateMortgage(mortgage)
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
