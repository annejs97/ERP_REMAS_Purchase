using REMAS.Forms;
using REMAS.Forms.Account;
using REMAS.Forms.Custom;
using REMAS.Forms.Purchasing;
using REMAS.Forms.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REMAS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmSplash FormSplash = new frmSplash();
            frmLogin FormLogin = new frmLogin(); // Buat instance FormLogin di sini

            // Mulai timer di FormSplash
            Timer timer = new Timer();
            timer.Interval = 5000; // 5 detik
            timer.Tick += (sender, args) =>
            {
                timer.Stop(); // Stop timer
                FormSplash.Hide(); // Sembunyikan FormSplash
                FormLogin.Show(); // Tampilkan FormLogin
            };

            // Event handler untuk menampilkan FormSplash ketika aplikasi dijalankan
            FormSplash.Load += (sender, args) =>
            {
                timer.Start(); // Mulai timer saat FormSplash dimuat
            };
            Application.Run(FormSplash);
        }
    }
}