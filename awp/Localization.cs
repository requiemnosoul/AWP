using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace awp
{
    internal class Localization
    {
        internal static void Ru()
        {
            string[] ruAwpForm = new [] {
                "Главная     ",
                "    Базы данных",
                "Отчеты      ",
                "Бэкап         ",
                " Настройки",
                "     О программе",
                "Automated WorkPlace"
            };
            
            for (int i = 0; i < AwpForm.cnt.Count; i++)
            {
                AwpForm.cnt[i].Text = ruAwpForm[i];
            }
        }
        public static void En()
        {
            
        }
    }
}