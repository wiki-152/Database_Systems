using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_Systems_Project
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public bool IsActive { get; set; }
    }
    internal class MenuManager
    {
        private static string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

        public static List<Menu> GetAllMenus()
        {
            List<Menu> menus = new List<Menu>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Menu", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Menu menu = new Menu();
                        menu.MenuId = reader.IsDBNull(reader.GetOrdinal("MenuId")) ? 0 : reader.GetInt32(reader.GetOrdinal("MenuId"));
                        menu.MenuName = reader.IsDBNull(reader.GetOrdinal("MenuName")) ? null : reader.GetString(reader.GetOrdinal("MenuName"));
                        menu.IsActive = reader.IsDBNull(reader.GetOrdinal("IsActive")) ? false : reader.GetBoolean(reader.GetOrdinal("IsActive"));
                        menus.Add(menu);
                    }
                }
            }
            return menus;
        }
    }
}
