(function () {
   var app = angular.module('app');

   var controllerId = 'adminusers';
   app.controller(controllerId, [
       '$scope', '$location', '$stateParams', 'abp.services.app.person',
       function ($scope, $location, $stateParams, personService) {
          var vm = this;

          var id = $stateParams.id;
          console.log($stateParams);

          vm.person;

          if (id < 1) {
             vm.person = {
                firstName: '',
                lastName: '',
                emailAddress: '',
                job: '',
                gender: ''
             };
          }
          else {
             abp.ui.setBusy(null,
             personService.getPersonById(id).success(function (data) {
                vm.person = data.personDto;
                console.log(data);
                console.log(vm.person);
             })
          )
          }

          var localize = abp.localization.getSource('TaskSystem');

          vm.savePerson = function () {
             if (id < 1) {
                abp.ui.setBusy(
                    null,
                    personService.createPerson(
                        vm.person
                    ).success(function () {
                       abp.notify.info(abp.utils.formatString(localize("{1}, {0} has been created."), vm.person.name, vm.person.job));
                       $location.path('/persons');
                    })
                );
             }
             else { //Update person
                console.log(vm.person);
                personService.updatePerson({
                   personId: vm.person.id,
                   firstName: vm.person.firstName,
                   lastName: vm.person.lastName,
                   emailAddress: vm.person.emailAddress,
                   job: vm.person.job,
                   gender: vm.person.gender
                }).success(function () {
                   $location.path('/persons');
                });
             }
          };
       }
   ]);
})();