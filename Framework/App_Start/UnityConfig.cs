using AutoMapper;
using Framework.Infrastructure.Mappings;
using Framework.Repository.Implement;
using Framework.Repository.Interface;
using Framework.Service.Implement;
using Framework.Service.Infrastructure.Mappings;
using Framework.Service.Interface;
using System;
using System.Data;
using System.Net.Http;
using Unity;
using Unity.Injection;

namespace Framework
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container

        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;

        #endregion Unity Container

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();

            //AutoMapper
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile<ControllerMapperingProfile>();
                    cfg.AddProfile<ServiceMappingProfile>();
                });
            container.RegisterInstance(config.CreateMapper());

            //DB

            // database connection - Wldo
            var Connection = "";

            // database connection - Mysql
            var MySQLConnection = "";

            //DB

            //Func<string,IDbConnection> connectionFactory = name =>
            //{
            //    var connectionText=ba
            //}
            //service
            container.RegisterType<ITestService, TestService>();

            container.RegisterType<ITestRepository, TestRepository>();

            //container.RegisterType<ITestService>(
            //    new InjectionFactory(c =>
            //    {
            //        var http = c.Resolve<HttpClient>();

            //        return new TestService(http);
            //    }));
        }
    }
}