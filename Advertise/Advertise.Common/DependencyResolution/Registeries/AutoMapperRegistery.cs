using System;
using System.Linq;
using Advertise.DomainClasses.Entities.Categories;
using Advertise.Mapping.Profiles.Categories;
using Advertise.ViewModel.Models.Categories.Category;
using AutoMapper;
using StructureMap;

namespace Advertise.Common.DependencyResolution.Registeries
{
    /// <summary>
    /// </summary>
    public class AutoMapperRegistery : Registry
    {
        /// <summary>
        /// </summary>
        public AutoMapperRegistery()
        {
            var profileAssembly = typeof (CategoryProfile).Assembly;
            var profiles =
                profileAssembly.GetTypes()
                    .Where(t => typeof (Profile).IsAssignableFrom(t))
                    .Select(t => (Profile) Activator.CreateInstance(t));

            var config = new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                    
                }
            });

            For<MapperConfiguration>().Use(config);
            For<IMapper>().Use(ctx => ctx.GetInstance<MapperConfiguration>().CreateMapper(ctx.GetInstance));
        }
    }
}