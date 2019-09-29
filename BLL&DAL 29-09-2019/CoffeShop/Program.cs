using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CoffeeShop());
            //Application.Run(new BookShop());
            //Application.Run(new CoffeeShopListUi());
            //Application.Run(new StudentIformatioListUi());
            //Application.Run(new SoldierUi());
           // Application.Run(new CoffeeShopDBUi());

            Application.Run(new CustomerUi());
        }
    }
}
