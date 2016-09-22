(function () {
   var app = angular.module('app');

   var controllerId = 'ts.views.task.newtask';
   app.controller(controllerId, [
       '$scope', '$location', '$stateParams', 'abp.services.app.task' , 'abp.services.app.person',
       function ($scope, $location, $stateParams, taskService, personService) {
          var vm = this;

          var id = $stateParams.id;
          console.log($stateParams);

          vm.task;

          if (id < 1) {
             vm.task = {
                title:'',
                description: '',
                assignedPersonId: null,
                completionTime: null
             };
          }
          else {
             console.log("Get task: " + id);
             abp.ui.setBusy(null,
             taskService.getTask(id).success(function (data) {
                vm.task = data.task;
                console.log(vm.task);
             })
          )};


          var localize = abp.localization.getSource('TaskSystem');

          vm.people = []; //TODO: Move Person combo to a directive?

          personService.getAllPeople().success(function (data) {
             vm.people = data.people;
          });

          vm.saveTask = function () {
             console.log(vm.task);
             //Check if task is new or edited
             if (id < 1) {
                abp.ui.setBusy(
                    null,
                    taskService.createTask(
                        vm.task
                    ).success(function () {
                       abp.notify.info(abp.utils.formatString(localize("TaskCreatedMessage"), vm.task.description));
                       $location.path('/');
                    })
                );
             }
             else { //This task's description/assignedperson? only needs to be updated
                taskService.updateTask({
                   taskId: vm.task.id,
                   assignedPersonId: vm.task.assignedPersonId,
                   title: vm.task.title,
                   description: vm.task.description
                }).success(function () {
                   $location.path('/');
                });
             }
          };
       }
   ]);
})();