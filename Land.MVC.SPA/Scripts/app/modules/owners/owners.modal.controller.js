(function () {
    'use strict';

    angular.module('app.modules.owners')
    .controller('OwnersModalController', OwnersModalController);

    OwnersModalController.$inject = ['$modalInstance', 'OwnersService', 'owners'];
    function OwnersModalController($modalInstance, ownersService, owners) {
        var vm = this;
        vm.owners = owners;
        
        function save(){
            if(owner.isNew){
                ownersService.createOwner(owner)
                .then(function (){
                    $modalInstance.close();
                
                    });
           } else {
                ownersService.updateOwner(owner)
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
