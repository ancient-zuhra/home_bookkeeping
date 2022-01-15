using System.Configuration;
namespace kursova_Zakharenko.Controller
{
    class ConnectionString
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["kursova_Zakharenko.Properties.Settings.ConnStr"].ConnectionString;
            }
        }
    }
}
