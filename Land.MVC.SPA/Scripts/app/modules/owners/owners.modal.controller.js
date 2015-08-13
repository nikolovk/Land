(function () {
    'use strict';

    angular.module('app.modules.owners')
    .controller('OwnersModalController', OwnersModalController);

    OwnersModalController.$inject = ['$modalInstance', 'OwnersService', 'data'];
    function OwnersModalController($modalInstance, ownersService, data) {
        var vm = this;
        function save(){
            $modalInstance.close();
        }

        function cancel() {
            $modalInstance.dismiss();
        }
    }
})();
