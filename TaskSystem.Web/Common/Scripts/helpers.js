var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('TaskSystem');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);