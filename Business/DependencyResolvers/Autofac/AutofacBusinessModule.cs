using System;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        public AutofacBusinessModule()
        {
        }

        //web api deki starpup ın içerisine yazdıklarımızı burada toplamak için kullanırız.
        protected override void Load(ContainerBuilder builder)
        {
            //services.addsingleton a karşılık gelir
            //biri senden ıuserserevice ister ise ona usermanager instance si ver demektir.
            //singleinstance 1 taner newlesin onu herkes kullansın
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            //builder.RegisterType<FileLogger>().As<ILogger>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<TicketManager>().As<ITicketService>().SingleInstance();
            builder.RegisterType<EfTicketDal>().As<ITicketDal>().SingleInstance();

            builder.RegisterType<TicketAttachementManager>().As<ITicketAttachementService>().SingleInstance();
            builder.RegisterType<EfTicketAttachementDal>().As<ITicketAttachementDal>().SingleInstance();

            builder.RegisterType<TicketMessageManager>().As<ITicketMessageService>().SingleInstance();
            builder.RegisterType<EfTicketMessageDal>().As<ITicketMessageDal>().SingleInstance();

            builder.RegisterType<TicketStatusManager>().As<ITicketStatusService>().SingleInstance();
            builder.RegisterType<EfTicketStatusDal>().As<ITicketStatusDal>().SingleInstance();

            builder.RegisterType<TicketTypeManager>().As<ITicketTypeService>().SingleInstance();
            builder.RegisterType<EfTicketTypeDal>().As<ITicketTypeDal>().SingleInstance();


            builder.RegisterType<TicketImageManager>().As<ITicketImageService>().SingleInstance();
            builder.RegisterType<EfTicketImageDal>().As<ITicketImageDal>().SingleInstance();



            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();
            //Core> aspect>autofac
            //bütün sınıflar için önce bir aspect i var mı diye bak.
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
