(function () {
    'use strict';

    angular.module('app.modules.mortages')
    .controller('MortagesController', MortagesController);

    MortagesController.$inject = ['$modal', 'MortagesService', 'LandPropertiesService'];
    function MortagesController($modal, mortagesService,landPropertiesService) {
        //TODO load data on route resolve
        var vm = this;
        mortagesService.getMortages()
        .then(function (mortages) {
            vm.mortages = mortages;
        });
        
        landPropertiesService.getLandProperties()
        .then(function (landProperties) {
            vm.landProperties = landProperties;
        });
        
        //////////////////
        
        modalOpen(mortage,isNew){
            mortage = mortage||{};
            mortage.isNew = isNew;
            $modal.open({
                templateUrl:'/templates/MortageModal',
                controller: 'MortageModalController',
                controllerAs: 'vm',
                backdropClass: 'backdrop-fixed',
                resolve: {
                        mortage: function () {
                            return mortage;
                        },
                        landProperties:vm.landProperties
                    }
            }).result.then(function (){
                        mortagesService.getMortages()
                      .then(function (mortages) {
                         vm.mortages = mortages;
                    });
                });
        }
    }
})();
