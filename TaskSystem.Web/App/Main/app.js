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
             url: '/newtask',
             templateUrl: '/App/Main/views/task/newtask.cshtml',
             menu: 'NewTask'
          })
           .state('persons', {
              url: '/persons',
              templateUrl: '/App/Main/views/persons/persons.cshtml',
              menu: 'Persons'
           })
           .state('newPerson', {
              url: '/newperson',
              templateUrl: '/App/Main/views/persons/newperson.cshtml',
              menu: 'NewPerson'
           });
       }
   ]);
})();