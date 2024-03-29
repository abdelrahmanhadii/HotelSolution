using System.Web.Mvc;
using HotelMVC.DAL;
using HotelMVC.Services;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace HotelMVC
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<RoomService>();
            container.RegisterType<GuestService>();
            container.RegisterType<RoomReservationService>();
            container.RegisterType<UserServic>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}