(function () {

   var app = angular.module('app');

   var controllerId = 'app.cache';

   app.controller(controllerId, [
       '$scope', 'abp.services.app.cache', function ($scope, cacheService) {
          var vm = this;

         // vm.localize = abp.localization.getSource('TaskSystem');

          console.log(cacheService);

          vm.ClearCache = function () {
             cacheService.clearCache().success(function () {
                //abp.notify.info(abp.utils.formatString(localize("Cache Cleared"), "Your cache has been cleared."));

             });
          };

          $('#cacheButton').click(function (e) {
             e.preventDefault();
             vm.ClearCache();
          });

       }]);
})();
