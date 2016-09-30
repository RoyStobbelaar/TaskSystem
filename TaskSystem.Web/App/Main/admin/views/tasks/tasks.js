(function () {
   var app = angular.module('app');

   var controllerId = 'admintasks';
   app.controller(controllerId, [
       '$scope', 'abp.services.app.task',
       function ($scope, taskService) {
          var vm = this;
          vm.title = "Jeeeuj mooie task man.";


          vm.tasks = [];

          $scope.$watch('selectedTaskState', function (value) {
             vm.refreshTasks();
          });

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
       }
   ]);
})();