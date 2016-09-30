using Abp.Application.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskSystem.Web.App_Start
{
   public class TaskSystemAdminModuleProvider : NavigationProvider
   {
      public override void SetNavigation(INavigationProviderContext context)
      {
         //Do something similar to addMenuItems
      }
   }
}