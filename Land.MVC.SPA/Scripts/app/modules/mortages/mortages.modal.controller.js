(function () {
    'use strict';

    angular.module('app.modules.mortages')
    .controller('MortagesModalController', MortagesModalController);

    MortagesModalController.$inject = ['$modalInstance', 'MortagesService', 'mortage', 'landProperties'];
    function MortagesModalController($modalInstance, mortagesService, mortage,landProperties) {
        var vm = this;
        vm.mortage = mortag;
        
        function save(){
            if(mortage.isNew){
                mortagesService.createMortage(mortage)
                .then(function (){
                    $modalInstance.close();
                
                    });
           } else {
                mortagesService.updateMortage(mortage)
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
