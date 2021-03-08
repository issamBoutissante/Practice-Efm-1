using System.Configuration;

namespace Practice_EFM_1
{
    class Global
    {
        internal static string connectionString = ConfigurationManager.ConnectionStrings["monConnection"].ConnectionString;
    }
}
