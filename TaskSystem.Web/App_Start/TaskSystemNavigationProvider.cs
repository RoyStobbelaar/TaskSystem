using Abp.Application.Navigation;
using Abp.Localization;
using TaskSystem.Authorization;

namespace TaskSystem.Web
{
   /// <summary>
   /// This class defines menus for the application.
   /// It uses ABP's menu system.
   /// When you add menu items here, they are automatically appear in angular application.
   /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
   /// </summary>
   public class TaskSystemNavigationProvider : NavigationProvider
   {
      public override void SetNavigation(INavigationProviderContext context)
      {
         context.Manager.MainMenu
             .AddItem(
            new MenuItemDefinition(
               "Home",
               new LocalizableString("HomePage", TaskSystemConsts.LocalizationSourceName),
               url: "#/",
               icon: "fa fa-home"
               )
             ).AddItem(
            new MenuItemDefinition(
               "TaskList",
               new LocalizableString("TaskList", TaskSystemConsts.LocalizationSourceName),
               url: "#tasklist",
               icon: "fa fa-globe"
               )
               ).AddItem(
            new MenuItemDefinition(
               "NewTask",
               new LocalizableString("NewTask", TaskSystemConsts.LocalizationSourceName),
               url: "#newtask",
               icon: "fa fa-globe"
               )
               ).AddItem(
            new MenuItemDefinition(
               "Persons",
               new LocalizableString("Persons", TaskSystemConsts.LocalizationSourceName),
               url: "#persons",
               icon: "fa fa-users"
               )
             );
      }

      private static ILocalizableString L(string name)
      {
         return new LocalizableString(name, TaskSystemConsts.LocalizationSourceName);
      }
   }
}
