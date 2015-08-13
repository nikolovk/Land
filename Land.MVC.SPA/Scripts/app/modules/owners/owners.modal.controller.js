(function () {
    'use strict';

    angular.module('app.modules.owners')
    .controller('OwnersModalController', OwnersModalController);

    OwnersModalController.$inject = ['$modalInstance', 'OwnersService', 'owner'];
    function OwnersModalController($modalInstance, ownersService, owner) {
        var vm = this;
        vm.owner = owner;
        vm.save = save;
        vm.cancel = cancel;
        
        function save() {
            if (vm.owner.isNew) {
                ownersService.createOwner(vm.owner)
                .then(function (){
                    $modalInstance.close();
                
                    });
           } else {
                ownersService.updateOwner(vm.owner)
                .then(function (){
                    $modalInstance.close();
                
                    });
           }
            
        }

        function cancel() {
            $modalInstance.dismiss();
        }
    }
})();
