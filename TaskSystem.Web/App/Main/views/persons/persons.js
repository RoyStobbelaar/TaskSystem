(function () {
   var app = angular.module('app');

   var controllerId = 'ts.views.persons.persons';
   app.controller(controllerId, [
       '$scope', 'abp.services.app.person',
       function ($scope, taskService) {
          var vm = this;

          vm.localize = abp.localization.getSource('TaskSystem');

          vm.tasks = [];

          $scope.selectedTaskState = 0;

          personService.getAllPeople().success(function (data) {
             vm.people = data.people;
          });
       }
   ]);
})();