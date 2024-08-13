using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_Systems_Project
{
    public class Promotion
    {
        public int PromotionId { get; set; }
        public string PromotionName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DiscountType { get; set; }
        public Decimal DiscountValue { get; set; }
        public bool isActive { get; set; }
    }
    internal class PromotionManager
    {
        private static string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

        public static List<Promotion> GetAllPromotions()
        {
            List<Promotion> promotions = new List<Promotion>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Promotions", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Promotion promotion = new Promotion();
                        promotion.PromotionId = reader.IsDBNull(reader.GetOrdinal("PromotionId")) ? 0 : reader.GetInt32(reader.GetOrdinal("PromotionId"));
                        promotion.PromotionName = reader.IsDBNull(reader.GetOrdinal("PromotionName")) ? null : reader.GetString(reader.GetOrdinal("PromotionName"));
                        promotion.Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description"));
                        promotion.StartDate = reader.IsDBNull(reader.GetOrdinal("StartDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("StartDate"));
                        promotion.EndDate = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("EndDate"));
                        promotion.DiscountType = reader.IsDBNull(reader.GetOrdinal("DiscountType")) ? null : reader.GetString(reader.GetOrdinal("DiscountType"));
                        promotion.DiscountValue = reader.IsDBNull(reader.GetOrdinal("DiscountValue")) ? 0 : reader.GetDecimal(reader.GetOrdinal("DiscountValue"));
                        promotion.isActive = reader.IsDBNull(reader.GetOrdinal("isActive")) ? false : reader.GetBoolean(reader.GetOrdinal("isActive"));

                        promotions.Add(promotion);
                    }
                }
            }
            return promotions;
        }
    }
}
