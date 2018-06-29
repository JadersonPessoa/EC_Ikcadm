using System.Configuration;

namespace EC_Ikcadm.Test.Dao
{
    public class Login_Dao
    {
        public static string Usuario = ConfigurationManager.AppSettings.GetValues("SA_User")[0];

        public static string Senha = ConfigurationManager.AppSettings.GetValues("SA_Pass")[0];
    }
}