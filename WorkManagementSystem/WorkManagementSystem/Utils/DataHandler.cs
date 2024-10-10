using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data;
using WorkManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace WorkManagementSystem.Utils
{
    public class DataHandler
    {
        const string connectionString = $"server=127.0.0.1;database=client_schedule;user=sqlUser;password=Passw0rd!;";


        public int ValidateUser(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Use parameterized query to prevent SQL injection
                    string query = "SELECT userId FROM user WHERE userName = @username AND password = @password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        int userId = reader.GetInt32("userId");  
                        reader.Close();
                        return userId;  // Return the userId
                    }
                    else
                    {
                        reader.Close();
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return -1;  // Return -1 on error
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public bool HasUpcomingAppointment(int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to check if an appointment exists within the next 15 minutes
                    string query = @"SELECT COUNT(*) FROM appointment 
                             WHERE userId = @userId 
                             AND TIMESTAMPDIFF(MINUTE, UTC_TIMESTAMP(), start) BETWEEN 0 AND 15";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public DataTable getCustomers()
        {
            DataTable dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    Console.WriteLine("Connection Successful");
                    conn.Open();
                    string query = @"SELECT c.customerId, c.customerName, a.address, a.address2, a.postalCode, a.phone, ci.city, a.addressId 
                             FROM customer c
                             JOIN address a ON c.addressId = a.addressId
                             JOIN city ci ON a.cityId = ci.cityId";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    adapter.Fill(dt);


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {

                    conn.Close();

                }
                return dt;
            }
        }

        public DataTable GetCities()
        {
            DataTable cities = new DataTable();

            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT cityId, city FROM city";  // Fetch city names and IDs
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.Fill(cities);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching cities: " + ex.Message);
                }
            }

            return cities;
        }

        public void AddCustomer(Customer customer, Address address, LoginUser user)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Insert into Address first, including createDate
                    string insertAddressQuery = @"INSERT INTO address (address, address2, postalCode, phone, cityId, createDate, createdBy, lastUpdateBy, lastUpdate) 
                                          VALUES (@address, @address2, @postalCode, @phone, @cityId, @createDate, @createdBy, @lastUpdateBy, @lastUpdate)";
                    MySqlCommand cmdAddress = new MySqlCommand(insertAddressQuery, conn);
                    cmdAddress.Parameters.AddWithValue("@address", address.AddressLine1);
                    cmdAddress.Parameters.AddWithValue("@address2", address.AddressLine2);
                    cmdAddress.Parameters.AddWithValue("@postalCode", address.PostalCode);
                    cmdAddress.Parameters.AddWithValue("@phone", address.Phone);
                    cmdAddress.Parameters.AddWithValue("@cityId", address.CityId);
                    cmdAddress.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                    cmdAddress.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                    cmdAddress.Parameters.AddWithValue("@createdBy", user.UserName);
                    cmdAddress.Parameters.AddWithValue("@lastUpdateBy", user.UserName);
                    cmdAddress.ExecuteNonQuery();

                    int addressId = (int)cmdAddress.LastInsertedId;

                    // Insert into Customer, including createDate
                    string insertCustomerQuery = @"INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy, lastUpdate) 
                                           VALUES (@customerName, @addressId, @active, @createDate, @createdBy, @lastUpdateBy, @lastUpdate)";
                    MySqlCommand cmdCustomer = new MySqlCommand(insertCustomerQuery, conn);
                    cmdCustomer.Parameters.AddWithValue("@customerName", customer.CustomerName);
                    cmdCustomer.Parameters.AddWithValue("@addressId", addressId);
                    cmdCustomer.Parameters.AddWithValue("@active", customer.Active);
                    cmdCustomer.Parameters.AddWithValue("@createDate", DateTime.UtcNow);
                    cmdCustomer.Parameters.AddWithValue("@lastUpdate", DateTime.UtcNow);
                    cmdCustomer.Parameters.AddWithValue("@createdBy", user.UserName);
                    cmdCustomer.Parameters.AddWithValue("@lastUpdateBy", user.UserName);
                    cmdCustomer.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding customer: " + ex.Message);
                }
            }
        }

        public void UpdateCustomer(Customer customer, Address address)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Update Address
                    string updateAddressQuery = @"UPDATE address 
                                          SET address = @address, address2 = @address2, postalCode = @postalCode, phone = @phone 
                                          WHERE addressId = @addressId";
                    MySqlCommand cmdAddress = new MySqlCommand(updateAddressQuery, conn);
                    cmdAddress.Parameters.AddWithValue("@address", address.AddressLine1);
                    cmdAddress.Parameters.AddWithValue("@address2", address.AddressLine2);
                    cmdAddress.Parameters.AddWithValue("@postalCode", address.PostalCode);
                    cmdAddress.Parameters.AddWithValue("@phone", address.Phone);
                    cmdAddress.Parameters.AddWithValue("@addressId", address.AddressId);
                    cmdAddress.ExecuteNonQuery();

                    // Update Customer
                    string updateCustomerQuery = @"UPDATE customer 
                                           SET customerName = @customerName, active = @active 
                                           WHERE customerId = @customerId";
                    MySqlCommand cmdCustomer = new MySqlCommand(updateCustomerQuery, conn);
                    cmdCustomer.Parameters.AddWithValue("@customerName", customer.CustomerName);
                    cmdCustomer.Parameters.AddWithValue("@active", customer.Active);
                    cmdCustomer.Parameters.AddWithValue("@customerId", customer.CustomerId);
                    cmdCustomer.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating customer: " + ex.Message);
                }
            }
        }

        public void DeleteCustomer(int customerId, int addressId)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Delete Customer first
                    string deleteCustomerQuery = "DELETE FROM customer WHERE customerId = @customerId";
                    MySqlCommand cmdCustomer = new MySqlCommand(deleteCustomerQuery, conn);
                    cmdCustomer.Parameters.AddWithValue("@customerId", customerId);
                    cmdCustomer.ExecuteNonQuery();

                    // Then delete Address
                    string deleteAddressQuery = "DELETE FROM address WHERE addressId = @addressId";
                    MySqlCommand cmdAddress = new MySqlCommand(deleteAddressQuery, conn);
                    cmdAddress.Parameters.AddWithValue("@addressId", addressId);
                    cmdAddress.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting customer: " + ex.Message);
                }
            }
        }

    }
}

