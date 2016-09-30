(function () {
   'use strict';

   var app = angular.module('app', [
       'ngAnimate',
       'ngSanitize',

       'ui.router',
       'ui.bootstrap',
       'ui.jq',

       'abp'
   ]);

   //Configuration for Angular UI routing.
   app.config([
       '$stateProvider', '$urlRouterProvider',
       function ($stateProvider, $urlRouterProvider) {
          $urlRouterProvider.otherwise('/tasklist');
          $stateProvider
          .state('tasklist', {
             url: '/tasklist',
             templateUrl: '/App/Main/views/task/tasklist.cshtml',
             menu: 'TaskList'
          })
          .state('newTask', {
             url: '/newtask/:id',//Id is optional. no ID = new / id = edit
             templateUrl: '/App/Main/views/task/newtask.cshtml',
             menu: 'NewTask'
          })
           .state('persons', {
              url: '/persons',
              templateUrl: '/App/Main/views/persons/persons.cshtml',
              menu: 'Persons'
           })
           .state('newPerson', {
              url: '/newperson/:id',//Id is optional. no ID = new / id = edit
              templateUrl: '/App/Main/views/persons/newperson.cshtml',
              menu: 'NewPerson'
           })
            .state('admin', {
               url: '/admin',//Id is optional. no ID = new / id = edit
               templateUrl: '/App/Main/admin/views/adminindex.cshtml'
            })
            .state('admin.Default', {
               url: '/admin',//Id is optional. no ID = new / id = edit
               templateUrl: '/App/Main/admin/views/defaultAdmin.cshtml'
            })
            .state('admin.Users', {
               url: '/User',//Id is optional. no ID = new / id = edit
               templateUrl: '/App/Main/admin/views/users/users.cshtml'
            })
            .state('admin.Tasks', {
               url: '/Task',//Id is optional. no ID = new / id = edit
               templateUrl: '/App/Main/admin/views/tasks/tasks.cshtml'
            })
            .state('admin.Settings', {
               url: '/Settings',//Id is optional. no ID = new / id = edit
               templateUrl: '/App/Main/admin/views/settings/settings.cshtml'
            })
            .state('admin.Other', {
               url: '/Other',//Id is optional. no ID = new / id = edit
               templateUrl: '/App/Main/admin/views/other/other.cshtml'
            })
            .state('admin.Cache', {
               url: '/Cache',//Id is optional. no ID = new / id = edit
               templateUrl: '/App/Main/admin/views/cache/cache.cshtml'
            })
            .state('admin.Game', {
               url: '/Game',//Id is optional. no ID = new / id = edit
               templateUrl: '/App/Main/admin/views/game/game.cshtml'
            });
       }
   ]);

   //Header control
   app.factory('Header', function () {
      var adminHeader = false;
      var header = "'/App/Main/admin/views/header/header.cshtml'";

      return {
         header: function () { return (adminHeader) ? '/App/Main/admin/views/header/header.cshtml' : '/App/Main/views/layout/header.cshtml'; },
         switchHeader: function () { adminHeader = !adminHeader; },
         admin: function () { return adminHeader; }
      };
   });
})();