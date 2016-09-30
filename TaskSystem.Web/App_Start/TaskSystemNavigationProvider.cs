using Abp.Application.Navigation;
using Abp.Localization;
using System.Collections.Generic;
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
         context.Manager.Menus.Add("AdminMenu", new MenuDefinition("AdminMenu", L("Admin Menu")));
         context.Manager.Menus["AdminMenu"]
            .AddItem(
            new MenuItemDefinition(
               "User",
               L("User"),
               url: "/User",
               icon: "fa fa-user"
               )
               ).AddItem(
            new MenuItemDefinition(
               "Task",
               L("Task"),
               url: "/Task",
               icon: "fa fa-tasks"
               )
               ).AddItem(
            new MenuItemDefinition(
               "Settings",
               L("Settings"),
               url: "/Settings",
               icon: "fa fa-cog"
               )
               ).AddItem(
            new MenuItemDefinition(
               "Other",
               L("Other"),
               url: "/Other",
               icon: "fa fa-asterisk"
               )
               ).AddItem(
            new MenuItemDefinition(
               "Cache",
               L("Cache"),
               url: "/Cache",
               icon: "fa fa-trash"
               )
               ).AddItem(
            new MenuItemDefinition(
               "Game",
               L("Game"),
               url: "/Game",
               icon: "fa fa-play-circle"
               )
            );


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
