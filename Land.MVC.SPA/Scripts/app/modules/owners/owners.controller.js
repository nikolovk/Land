(function () {
    'use strict';

    angular.module('app.modules.owners')
    .controller('OwnersController', OwnersController);

    OwnersController.$inject = ['$modal', 'OwnersService'];
    function OwnersController($modal, ownersService) {
        //TODO load data on route resolve
        var vm = this;
        ownersService.getOwners()
        .then(function (owners) {
            vm.owners = owners;
            vm.modalOpen = modalOpen;
        });

        //////////////////

        function modalOpen(owner, isNew) {
            owner = owner || {};
            owner.isNew = isNew;
            $modal.open({
                templateUrl: '/templates/OwnersModal',
                controller: 'OwnersModalController',
                controllerAs: 'vm',
                backdropClass: 'backdrop-fixed',
                resolve: {
                    owner: function () {
                        return owner;
                    }
                }
            }).result.then(function () {
                ownersService.getOwners()
              .then(function (owners) {
                  vm.owners = owners;
              });
            });
        }
    }
})();
