(function () {
   var app = angular.module('app');

   var controllerId = 'ts.views.persons.newperson';
   app.controller(controllerId, [
       '$scope', '$location', 'abp.services.app.person',
       function ($scope, $location, personService) {
          var vm = this;

          vm.person = {
             name: '',
             job:''
          };

          var localize = abp.localization.getSource('TaskSystem');

          vm.savePerson = function () {
             abp.ui.setBusy(
                 null,
                 personService.createPerson(
                     vm.person
                 ).success(function () {
                    abp.notify.info(abp.utils.formatString(localize("{1}, {0} has been created." ), vm.person.name,vm.person.job));
                    $location.path('/persons');
                 })
             );
          };
       }
   ]);
})();