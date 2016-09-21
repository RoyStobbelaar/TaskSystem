(function () {
   var app = angular.module('app');

   var controllerId = 'ts.views.task.tasklist';
   app.controller(controllerId, [
       '$scope', 'abp.services.app.task',
       function ($scope, taskService) {
          var vm = this;

          vm.localize = abp.localization.getSource('TaskSystem');

          vm.tasks = [];

          $scope.$watch('selectedTaskState', function (value) {
             vm.refreshTasks();
          });

          
          vm.removeTask = function (taskId) {

             
             abp.message.confirm(
                'This task will be deleted',
                'Are you sure?',
                function (isConfirmed) {
                   if (isConfirmed) {


                      abp.ui.setBusy(
                         null,
                         taskService.deleteTask(taskId).success(function () {
                            abp.message.success('Removed', 'Task successfully removed.')
                            //abp.notify.info(abp.utils.formatString(vm.localize("Task has been removed")));
                            vm.refreshTasks();
                         })
                      )
                   }
                }
                );
          };

          vm.refreshTasks = function () {
             abp.ui.setBusy( //Set whole page busy until getTasks complete
                 null,
                 taskService.getTasks({ //Call application service method directly from javascript
                    state: $scope.selectedTaskState > 0 ? $scope.selectedTaskState : null
                 }).success(function (data) {
                    console.log(data);
                    vm.tasks = data.tasks;
                 })
             );
          };

          vm.changeTaskState = function (task) {
             var newState;
             if (task.state == 1) {
                newState = 2; //Progress
             }
             else if(task.state == 2){
                newState = 3; //Complete
             } else {
                newState = 1; //Active
             }

             taskService.updateTask({
                taskId: task.id,
                state: newState
             }).success(function () {
                task.state = newState;
                abp.notify.info(vm.localize('TaskUpdatedMessage'));
                console.log(task);
             });
          };

          vm.getTaskCountText = function () {
             return abp.utils.formatString(vm.localize('Current tasks'), vm.tasks.length);
          };
       }
   ]);
})();