(function () {
    var appAdmin = angular.module('app');

   var controllerId = 'admin.header';
   appAdmin.controller(controllerId, [
       '$rootScope', '$state', 'appSession',
       function ($rootScope, $state, appSession) {
          var vm = this;

          vm.languages = abp.localization.languages;
          vm.currentLanguage = abp.localization.currentLanguage;

          vm.menu = abp.nav.menus.AdminMenu;
          vm.currentMenuName = $state.current.menu;

          console.log(vm.menu);

          $rootScope.$on('$stateChangeSuccess', function (event, toState, toParams, fromState, fromParams) {
             vm.currentMenuName = toState.menu;
          });

          //Select or deselect admin mode
          //vm.changeAdmin = function () {
          //   Header.switchHeader();
          //};

          abp.event.on('abp.notifications.received', function (userNotification) {
             abp.notifications.showUiNotifyForUserNotification(userNotification);
          });
       }
   ]);
})();