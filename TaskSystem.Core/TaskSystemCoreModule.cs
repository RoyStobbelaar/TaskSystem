using System.Reflection;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Zero;
using Abp.Zero.Configuration;
using TaskSystem.Authorization;
using TaskSystem.Authorization.Roles;
using TaskSystem.MultiTenancy;
using TaskSystem.Users;

namespace TaskSystem
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class TaskSystemCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            //Remove the following line to disable multi-tenancy.
            Configuration.MultiTenancy.IsEnabled = true;

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    TaskSystemConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        Assembly.GetExecutingAssembly(),
                        "TaskSystem.Localization.Source"
                        )
                    )
                );

            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Authorization.Providers.Add<TaskSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
