(function () {
    var controllerId = 'app.views.layout';
    angular.module('app').controller(controllerId, [
        '$scope', function ($scope) {
           var vm = this;

        }]);
})();

(function () {
   var controllerId = 'layoutController';
   angular.module('app').controller(controllerId, [
       '$scope', 'Header', function ($scope, Header) {
          var vm = this;
          vm.Header = Header;
       }]);
})();