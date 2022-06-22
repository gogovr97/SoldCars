namespace SoldCars
{
    using System;
    using System.Windows.Forms;

    using SoldCars.Database;

    using Microsoft.EntityFrameworkCore;

    static class Program
    {
        [STAThread]
        static void Main()
        {
            SoldCarsDbContext dbContext = new SoldCarsDbContext();
            dbContext.Database.Migrate();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(dbContext));
        }
    }
}
