using Advertise.ViewModel.Profiles.Categories;
using AutoMapper;

namespace Advertise.Web
{
    /// <summary>
    /// 
    /// </summary>
    public class AutoMapperConfig
    {
        /// <summary>
        /// 
        /// </summary>
        public static void RegisterAutoMapper()
        {
            var config = new MapperConfiguration(cfg => // In Application_Start()
            {
                cfg.AddProfile<CategoryProfile>();
            });
            config.AssertConfigurationIsValid();
        }
    }
}
