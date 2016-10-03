//(function () {
//    var appAdmin = angular.module('admin', [
//        'ngAnimate',
//        'ngSanitize',

//        'ui.router',
//        'ui.bootstrap',
//        'ui.jq',

//        'abp'
//    ]);

//    //Configuration for Angular UI routing.
//    appAdmin.config([
//        '$stateProvider', '$urlRouterProvider',
//        function ($stateProvider, $urlRouterProvider) {
//            //$urlRouterProvider.otherwise('/admin');
//            $stateProvider
//              .state('admin', {
//                  url: '/admin',//Id is optional. no ID = new / id = edit
//                  templateUrl: '/App/Main/admin/views/adminindex.cshtml',
//                  controller:'admin.layout'
//              })
//              .state('admin.Default', {
//                  url: '/admin',//Id is optional. no ID = new / id = edit
//                  templateUrl: '/App/Main/admin/views/defaultAdmin.cshtml'
//              })
//              .state('admin.Users', {
//                  url: '/User',//Id is optional. no ID = new / id = edit
//                  templateUrl: '/App/Main/admin/views/users/users.cshtml'
//              })
//              .state('admin.Tasks', {
//                  url: '/Task',//Id is optional. no ID = new / id = edit
//                  templateUrl: '/App/Main/admin/views/tasks/tasks.cshtml'
//              })
//              .state('admin.Settings', {
//                  url: '/Settings',//Id is optional. no ID = new / id = edit
//                  templateUrl: '/App/Main/admin/views/settings/settings.cshtml'
//              })
//              .state('admin.Other', {
//                  url: '/Other',//Id is optional. no ID = new / id = edit
//                  templateUrl: '/App/Main/admin/views/other/other.cshtml'
//              })
//              .state('admin.Cache', {
//                  url: '/Cache',//Id is optional. no ID = new / id = edit
//                  templateUrl: '/App/Main/admin/views/cache/cache.cshtml'
//              })
//              .state('admin.Game', {
//                  url: '/Game',//Id is optional. no ID = new / id = edit
//                  templateUrl: '/App/Main/admin/views/game/game.cshtml'
//              });
//        }
//    ]);

//    //Header control
//    //appAdmin.factory('Header', function () {
//    //    var adminHeader = false;
//    //    var header = "'/App/Main/admin/views/header/header.cshtml'";

//    //    return {
//    //        header: function () { return (adminHeader) ? '/App/Main/admin/views/header/header.cshtml' : '/App/Main/views/layout/header.cshtml'; },
//    //        switchHeader: function () { adminHeader = !adminHeader; },
//    //        admin: function () { return adminHeader; }
//    //    };
//    //});
//})();