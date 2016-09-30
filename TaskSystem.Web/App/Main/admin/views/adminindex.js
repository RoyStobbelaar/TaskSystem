(function () {

   var app = angular.module('app');

   var controllerId = 'app.admin';

   app.controller(controllerId, [
       '$scope', 'abp.services.app.module', function ($scope, moduleService) {
          var vm = this;

          vm.admintext = "Welcome to the admin page :-)"

          console.log(moduleService);

          vm.modules = [];

          vm.GetAllModules = function () {
             moduleService.getModules().success(function (data) {
                vm.modules = data.modules;
                console.log(data);
             })
          };
          vm.GetAllModules();

          vm.menu = abp.nav.menus.AdminMenu;

          console.log(vm.menu);

          //vm.GetAllPersons = function () {
          //   personService.getAllPeople().success(function (data) {
          //      vm.people = data.people;
          //      console.log(vm.people);
          //   })
          //};

          console.log(vm.modules);
       }]);
})();
