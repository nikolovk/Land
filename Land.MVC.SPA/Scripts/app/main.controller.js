﻿(function () {
    'use strict';

    angular.module('app')
    .controller('MainController', MainController);

    MainController.$inject = [];
    function MainController(ownersService) {
        var vm = this;
        vm.test = "AAAAAAAAA";
    }
})();