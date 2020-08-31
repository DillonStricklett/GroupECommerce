using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace GroupECommerce
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            using (Scope scope = AsyncScopedLifestyle.BeginScope(container))
			{                
                Application.Run(container.GetInstance<MainForm>());
            }
        }

        private static void Bootstrap()
		{
            container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IProductContext, ProductContext>(Lifestyle.Singleton);
            container.Register<MainForm>(Lifestyle.Scoped);

            container.Verify();
		}
    }
}
