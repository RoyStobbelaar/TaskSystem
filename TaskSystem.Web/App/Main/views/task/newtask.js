(function () {
   var app = angular.module('app');

   var controllerId = 'ts.views.task.newtask';
   app.controller(controllerId, [
       '$scope', '$location', 'abp.services.app.task' , 'abp.services.app.person',
       function ($scope, $location, taskService, personService) {
          var vm = this;

          vm.task = {
             description: '',
             assignedPersonId: null,
             completionTime:null
          };

          var localize = abp.localization.getSource('TaskSystem');

          vm.people = []; //TODO: Move Person combo to a directive?

          personService.getAllPeople().success(function (data) {
             vm.people = data.people;
          });

          vm.saveTask = function () {
             console.log(vm.task);
             abp.ui.setBusy(
                 null,
                 taskService.createTask(
                     vm.task
                 ).success(function () {
                    abp.notify.info(abp.utils.formatString(localize("TaskCreatedMessage"), vm.task.description));
                    $location.path('/');
                 })
             );
          };
       }
   ]);
})();