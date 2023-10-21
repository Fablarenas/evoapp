using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlayerUI
{
    static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var serviceProvider = new Startup().ConfigureServices();
            using (var scope = serviceProvider.CreateScope())
            {
                var mainForm = scope.ServiceProvider.GetRequiredService<Form1>();

                Application.Run(mainForm);
            }
        }
    }
}
