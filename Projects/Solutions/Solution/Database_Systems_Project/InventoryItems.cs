using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database_Systems_Project
{
    public class InventoryItems
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int QuantityInStock { get; set; }
        public string UnitOfMeasurement { get; set; }
        public int ReorderThreshold { get; set; }
        public int SupplierId { get; set; }
    }

    internal class InventoryItemsManager
    {
        private static string connectionString = "Data Source=WIKI\\SQLEXPRESS;Initial Catalog=Database_Systems_Project; Integrated Security=True; Encrypt=false";

        public static List<InventoryItems> GetAllInventoryItems()
        {
            List<InventoryItems> inventoryItems = new List<InventoryItems>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM InventoryItems", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // if null, set accordingly
                        InventoryItems inventoryItem = new InventoryItems();
                        inventoryItem.ItemId = reader.IsDBNull(reader.GetOrdinal("ItemId")) ? 0 : reader.GetInt32(reader.GetOrdinal("ItemId"));
                        inventoryItem.ItemName = reader.IsDBNull(reader.GetOrdinal("ItemName")) ? null : reader.GetString(reader.GetOrdinal("ItemName"));
                        inventoryItem.QuantityInStock = reader.IsDBNull(reader.GetOrdinal("QuantityInStock")) ? 0 : reader.GetInt32(reader.GetOrdinal("QuantityInStock"));
                        inventoryItem.UnitOfMeasurement = reader.IsDBNull(reader.GetOrdinal("UnitOfMeasurement")) ? null : reader.GetString(reader.GetOrdinal("UnitOfMeasurement"));
                        inventoryItem.ReorderThreshold = reader.IsDBNull(reader.GetOrdinal("ReorderThreshold")) ? 0 : reader.GetInt32(reader.GetOrdinal("ReorderThreshold"));
                        inventoryItem.SupplierId = reader.IsDBNull(reader.GetOrdinal("SupplierId")) ? 0 : reader.GetInt32(reader.GetOrdinal("SupplierId"));

                        inventoryItems.Add(inventoryItem);
                    }
                }
            }
            return inventoryItems;
        }

        public static void UpdateInventoryItem(int itemId, string itemName, int quantityInStock, string unitOfMeasurement, int reorderThreshold, int supplierId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE InventoryItems SET ItemName = @ItemName, QuantityInStock = @QuantityInStock, UnitOfMeasurement = @UnitOfMeasurement, ReorderThreshold = @ReorderThreshold, SupplierId = @SupplierId WHERE ItemId = @ItemId", conn);
                cmd.Parameters.AddWithValue("@ItemId", itemId);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
                cmd.Parameters.AddWithValue("@UnitOfMeasurement", unitOfMeasurement);
                cmd.Parameters.AddWithValue("@ReorderThreshold", reorderThreshold);
                cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteInventoryItem(int itemId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM InventoryItems WHERE ItemId = @ItemId", conn);
                cmd.Parameters.AddWithValue("@ItemId", itemId);
                cmd.ExecuteNonQuery();
            }
        }

        // Add new inventory item
        public static void AddInventoryItem(string itemName, int quantityInStock, string unitOfMeasurement, int reorderThreshold, int supplierId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO InventoryItems (ItemName, QuantityInStock, UnitOfMeasurement, ReorderThreshold, SupplierId) VALUES (@ItemName, @QuantityInStock, @UnitOfMeasurement, @ReorderThreshold, @SupplierId)", conn);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@QuantityInStock", quantityInStock);
                cmd.Parameters.AddWithValue("@UnitOfMeasurement", unitOfMeasurement);
                cmd.Parameters.AddWithValue("@ReorderThreshold", reorderThreshold);
                cmd.Parameters.AddWithValue("@SupplierId", supplierId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
