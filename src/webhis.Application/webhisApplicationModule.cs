using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using webhis.Authorization;

namespace webhis
{
    [DependsOn(
        typeof(webhisCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class webhisApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<webhisAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(webhisApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
