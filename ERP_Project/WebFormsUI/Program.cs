using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace WebFormsUI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          
            var services = new ServiceCollection();

            
            services.AddScoped<IUserDal, UserDal>();
            services.AddScoped<IUserScreenDal, UserScreenDal>();

            services.AddScoped<ILogInService, LogInManager>();

          
            services.AddScoped<LogInPage>();

           
            var serviceProvider = services.BuildServiceProvider();

            
            var loginForm = serviceProvider.GetRequiredService<LogInPage>();
            Application.Run(loginForm); 
            
          







        }
    }
}
