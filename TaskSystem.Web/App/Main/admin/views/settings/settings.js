(function () {
   var app = angular.module('app');

   var controllerId = 'adminSettings';
   app.controller(controllerId, [
       '$scope', 'abp.services.app.task',
       function ($scope, taskService) {
          var vm = this;
          vm.title = "Settings.";

          vm.subtitle = "Change global app settings here :-)";

       }
   ]);
})();