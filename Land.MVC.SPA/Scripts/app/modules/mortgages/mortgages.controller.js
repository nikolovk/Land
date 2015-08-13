(function () {
    'use strict';

    angular.module('app.modules.mortgages')
    .controller('mortgagesController', mortgagesController);

    mortgagesController.$inject = ['$modal', 'mortgagesService'];
    function mortgagesController($modal, mortgagesService) {
        //TODO load data on route resolve
        var vm = this;
        mortgagesService.getMortgages()
        .then(function (mortgages) {
            vm.mortgages = mortgages;
        });

        
        //////////////////
        

    }
})();
