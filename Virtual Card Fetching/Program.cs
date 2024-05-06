namespace Virtual_Card_Fetching
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
            Application.Run(new MainForm());
        }

        public static class Globals
        {

            public static String con_host = ""; //dbhost
            public static String con_database = ""; //schema
            public static String con_username = ""; //username
            public static String con_password = ""; //password
            public static String con_port = ""; //port

        }
    }
}