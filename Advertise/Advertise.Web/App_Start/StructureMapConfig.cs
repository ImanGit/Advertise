using System;
using System.Linq;
using System.Web.Mvc;
using Advertise.Common.Controller;
using Advertise.Common.DependencyResolution;
using Advertise.Common.Json;
using Advertise.ServiceLayer.Contracts.Common;
using CaptchaMvc.Infrastructure;

namespace Advertise.Web
{
    /// <summary>
    /// </summary>
    public class StructureMapConfig
    {
        /// <summary>
        /// </summary>
        public static void RegisterStructureMap()
        {
            // disable response header for protection  attak
            MvcHandler.DisableMvcResponseHeader = true;

            // change captcha provider for using cookie
            CaptchaUtils.CaptchaManager.StorageProvider = new CookieStorageProvider();
            CaptchaUtils.ImageGenerator.Height = 50;

            //Set current Controller factory as StructureMapControllerFactory
            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());

            //set current Filter factory as StructureMapFitlerProvider
            var filterProider = FilterProviders.Providers.Single(p => p is FilterAttributeFilterProvider);
            FilterProviders.Providers.Remove(filterProider);
            FilterProviders.Providers.Add(ApplicationObjectFactory.Container.GetInstance<StructureMapFilterProvider>());

            // set default Json Factory
            var defaultJsonFactory =
                ValueProviderFactories.Factories.OfType<JsonValueProviderFactory>().FirstOrDefault();
            var index = ValueProviderFactories.Factories.IndexOf(defaultJsonFactory);
            ValueProviderFactories.Factories.Remove(defaultJsonFactory);
            ValueProviderFactories.Factories.Insert(index, new JsonNetValueProviderFactory());

            foreach (var task in ApplicationObjectFactory.Container.GetAllInstances<IRunAtInit>())
            {
                task.Execute();
            }

            //GlobalHost.DependencyResolver = ApplicationObjectFactory.Container.GetInstance<Microsoft.AspNet.SignalR.IDependencyResolver>();
            ModelBinders.Binders.Add(typeof (DateTime), new PersianDateModelBinder());
            ModelBinders.Binders.Add(typeof (DateTime?), new PersianDateModelBinder());
            ModelBinders.Binders.Add(typeof (decimal), new DecimalModelBinder());
            ModelBinders.Binders.Add(typeof (decimal?), new DecimalModelBinder());

            //DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
        }
    }
}