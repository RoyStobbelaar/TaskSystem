(function () {
   var app = angular.module('app');

   var controllerId = 'ts.views.persons.persons';
   app.controller(controllerId, [
       '$scope', 'abp.services.app.person',
       function ($scope, personService) {
          var vm = this;

          vm.people = [];

          var localize = abp.localization.getSource('TaskSystem');


          vm.GetAllPersons = function () {
             personService.getAllPeople().success(function (data) {
                vm.people = data.people;
                console.log(vm.people);
             })
          };

          personService.getAllPeople().success(function (data) {
             vm.people = data.people;
             console.log(vm.people);

          });

          vm.removePerson = function (id) {
             console.log("Click!" + id);

             abp.message.confirm(
                'This person will be deleted',
                'Are you sure?',
                function (isConfirmed) {
                   if (isConfirmed) {

                      abp.ui.setBusy(
                null,
                personService.deletePerson(id).success(function () {

                   abp.message.success('Removed', 'Person successfully removed.')
                   //abp.notify.info(abp.utils.formatString(localize("Person has been removed")));

                   vm.GetAllPersons();
                })
             )

                   }
                }
                )
          };
          vm.GetAllPersons();
       }
   ]);
})();