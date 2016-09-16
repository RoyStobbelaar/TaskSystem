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
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');
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
            .state('home', {
               url: '/',
               templateUrl: '/App/Main/views/home/home.cshtml',
               menu: 'Home' //Matches to name of 'Home' menu in TaskSystemNavigationProvider
            })
            .state('persons', {
               url: '/persons',
               templateUrl: '/App/Main/views/persons/persons.cshtml',
               menu: 'Persons'
            });
        }
    ]);
})();