(function () {
    'use strict';

    angular.module('app.modules.owners')
    .controller('OwnersController', OwnersController);

    OwnersController.$inject = ['OwnersService'];
    function OwnersController(ownersService) {
        var vm = this;
        ownersService.getOwners()
        .then(function (owners) {
            vm.owners = owners;
        });
    }
})();