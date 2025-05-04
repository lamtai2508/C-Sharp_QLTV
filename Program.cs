using qltv.GUI.UI_For_Login;
using QLTV;
using qltv.GUI.UI_For_User;


namespace qltv
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormAdminDashboard());
            //Application.Run(new Login());
        }
    }
}