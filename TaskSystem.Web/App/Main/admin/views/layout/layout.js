(function () {
    var controllerId = 'admin.layout';
    angular.module('app').controller(controllerId, [
        '$scope', 'abp.services.app.module', function ($scope, moduleService) {
            var vm = this;
            vm.admintext = "Welcome to the admin page :-)"
            console.log(moduleService);
            vm.modules = [];
            vm.GetAllModules = function () {
                moduleService.getModules().success(function (data) {
                    vm.modules = data.modules;
                    console.log(data);
                })
            };
            vm.GetAllModules();
            vm.menu = abp.nav.menus.AdminMenu;
            console.log(vm.menu);
            console.log(vm.modules);
        }]);
})();