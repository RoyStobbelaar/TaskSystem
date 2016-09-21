(function() {
    var controllerId = 'app.views.home';
    angular.module('app').controller(controllerId, [
        '$scope', function($scope) {
            var vm = this;
           //Home logic...

            vm.title = "Roy's Tasklist";
            vm.welcomeMessage = "Keep track of your tasks :> ";

        }
    ]);
})();