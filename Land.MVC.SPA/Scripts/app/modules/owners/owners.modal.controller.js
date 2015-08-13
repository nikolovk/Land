(function () {
    'use strict';

    angular.module('app.modules.owners')
    .controller('OwnersModalController', OwnersModalController);

    OwnersModalController.$inject = ['$modalInstance', 'OwnersService', 'data'];
    function OwnersModalController($modalInstance, ownersService, data) {
        var vm = this;
        function ok (){
            $modalInstance.close();
        }

        function cancel() {
            $modalInstance.dismiss();
        }
    }
})();