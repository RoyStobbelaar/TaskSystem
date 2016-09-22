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
               "TaskList",
               L("Task List"),
               url: "#/",
               icon: "fa fa-list-alt"
               )
               ).AddItem(
            new MenuItemDefinition(
               "NewTask",
               L("New Task"),
               url: "#/newtask/",
               icon: "fa fa-plus"
               )
               ).AddItem(
            new MenuItemDefinition(
               "Persons",
               L("Person List"),
               url: "#/persons",
               icon: "fa fa-users"
               )
               ).AddItem(
            new MenuItemDefinition(
               "NewPerson",
               L("New Person"),
               url: "#/newperson/",
               icon: "fa fa-plus"
               )
             );

      }

      private static ILocalizableString L(string name)
      {
         return new LocalizableString(name, TaskSystemConsts.LocalizationSourceName);
      }
   }
}
