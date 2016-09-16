(function() {
    var controllerId = 'app.views.home';
    angular.module('app').controller(controllerId, [
        '$scope', function($scope) {
            var vm = this;
           //Home logic...

            this.welcomeMessage = "Heya!, Welcome here :) Enjoy creating some tasks. ";

            vm.title = "TaskSystem!";
            vm.welcomeMessage = "Heya!, Welcome here :) Enjoy creating some tasks. ";

        }
    ]);
})();