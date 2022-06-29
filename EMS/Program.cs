namespace EMS
{
    internal static class Program
    {
        private static dashboard dashboard;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            dashboard = new dashboard();
            Application.Run(new forms1(            //employeeAdd.BringToFront();
            dashboard));
        }
    }
}