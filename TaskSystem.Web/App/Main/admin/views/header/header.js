﻿(function () {
   var app = angular.module('app');

   var controllerId = 'adminheader';
   app.controller(controllerId, [
       '$rootScope', '$state', 'appSession', 'Header',
       function ($rootScope, $state, appSession, Header) {
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
          vm.changeAdmin = function () {
             Header.switchHeader();
          };

          abp.event.on('abp.notifications.received', function (userNotification) {
             abp.notifications.showUiNotifyForUserNotification(userNotification);
          });
       }
   ]);
})();