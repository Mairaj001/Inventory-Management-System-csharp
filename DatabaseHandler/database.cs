using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Inventory_Management_System.DatabaseHandler
{
    internal class Database
    {
        public int Productid { get; set; }
        public string ProductName { get; set; }
        public string catogry { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public Double Price { get; set; }


        public string User_Name { get; set; }    

        public string User_Email {  get; set; }

       public string User_address { get; set; } 

       public decimal Total_price { get; set; }  

        public string gender { get; set; }

        public int orderId { get; set; }
        




        string connstring= "Server=localhost;Port=5432;Database=Inventory;User Id=postgres;Password=House167";

        public int GetTotalQuantityOfProducts()
        {
            int totalQuantity = 0;

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT SUM(quantity) FROM products";

                object result = comm.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    totalQuantity = Convert.ToInt32(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }

            return totalQuantity;
        }


        public DataTable Select()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();

                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select *from products";
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {

                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            catch (Exception e)
            {


            }
            finally
            {
                comm.Dispose();
                conn.Close();

            }
            return null;
        }

        public int GetTotalRowsInOrders()
        {
            int totalRows = 0;

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT COUNT(*) FROM orders";

                totalRows = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }

            return totalRows;
        }

        public int GetTotalRowsInCustomers()
        {
            int totalRows = 0;

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT COUNT(*) FROM users";

                totalRows = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }

            return totalRows;
        }

        public decimal GetTotalPriceOfCompletedOrders()
        {
            decimal totalPrice = 0;

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT SUM(TotalPrice) AS TotalPrice FROM orders WHERE status = 'Completed'";

                object result = comm.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    totalPrice = Convert.ToDecimal(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }

            return totalPrice;
        }


        public DataTable User_Select()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();

                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select *from users";
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {

                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            catch (Exception e)
            {


            }
            finally
            {
                comm.Dispose();
                conn.Close();

            }
            return null;
        }
        public DataTable Users_Select()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();

                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select *from users";
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {

                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            catch (Exception e)
            {


            }
            finally
            {
                comm.Dispose();
                conn.Close();

            }
            return null;
        }
       
        public DataTable Orders_Select()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();

                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select *from orders";
                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {

                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            catch (Exception e)
            {


            }
            finally
            {
                comm.Dispose();
                conn.Close();

            }
            return null;
        }


        public bool Delete_order()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "DELETE from orders where orderid=@orderid";
                comm.Parameters.AddWithValue("@orderid", this.orderId);

                comm.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {


                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }


            return false;
        }

        public DataTable Get_orders_wrt_email(int UserId)
        {

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();

                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select *from orders where userid=@UserId ";
                comm.Parameters.AddWithValue("@UserId", UserId);

                NpgsqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {

                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            catch (Exception e)
            {


            }
            finally
            {
                comm.Dispose();
                conn.Close();

            }
            return null;
        }
    
        public int GetUserIdByEmail()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();
            int userId = -1; // Assuming -1 as default or error value

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT id FROM users WHERE email = @Email";
                comm.Parameters.AddWithValue("@Email",this.User_Email);

                // ExecuteScalar is used to fetch a single value
                object result = comm.ExecuteScalar();

                if (result != null)
                {
                    userId = Convert.ToInt32(result); // Convert the result to int
                    Console.WriteLine(userId);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }

            return userId;
        }

        public bool UpdateOrder( decimal totalPrice)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "UPDATE orders SET ProductId = @ProductId, Quantity = @Quantity, TotalPrice = @TotalPrice, Address = @Address WHERE OrderId = @OrderId";
                comm.Parameters.AddWithValue("@ProductId", this.Productid);
                comm.Parameters.AddWithValue("@Quantity", this.Quantity);
                comm.Parameters.AddWithValue("@TotalPrice", totalPrice);
                comm.Parameters.AddWithValue("@Address", this.User_address);
                comm.Parameters.AddWithValue("@OrderId", this.orderId);
                comm.ExecuteNonQuery();
                Console.WriteLine("Order updated successfully.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public bool InsertUser()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "INSERT INTO users (name, email, gender) VALUES (@Name, @Email, @gender)";
                comm.Parameters.AddWithValue("@Name", this.User_Name);
                comm.Parameters.AddWithValue("@Email", this.User_Email);
                comm.Parameters.AddWithValue("@gender", this.gender);
                comm.ExecuteNonQuery();
                Console.WriteLine("User added successfully.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }

            return false;
        }
        public string status = "InProgress";
        public bool InsertOrder(int userId)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "INSERT INTO orders (UserId, ProductId, Quantity, TotalPrice,address,status) VALUES (@UserId, @ProductId, @Quantity, @TotalPrice, @address,@status)";
                comm.Parameters.AddWithValue("@UserId", userId);
                comm.Parameters.AddWithValue("@ProductId",this.Productid);
                comm.Parameters.AddWithValue("@Quantity", this.Quantity);
                comm.Parameters.AddWithValue("@TotalPrice", this.Total_price);
                comm.Parameters.AddWithValue("@address", this.User_address);
                comm.Parameters.AddWithValue("@status",status);
                comm.ExecuteNonQuery();
                Console.WriteLine("Order added successfully.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }


        public DataTable GetInProgressOrdersDetails()
        {
            DataTable ordersTable = new DataTable();
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = @"
            SELECT 
                users.name AS UserName, 
                
                  
                 products.productname AS ProductName, 
                 products.category AS ProductCategory, 
                 products.brand AS ProductBrand, 
                  products.size AS ProductSize,
                  orders.orderid,
                 orders.Quantity, 
                 orders.address AS ShippingAddress, 
                 orders.TotalPrice,
	             orders.status
                FROM 
                  orders
                INNER JOIN 
                users ON orders.UserId = users.id
                 INNER JOIN 
                 products ON orders.ProductId = products.productid
                 WHERE 
                 orders.status = 'InProgress';";

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(comm);
                adapter.Fill(ordersTable);

                return ordersTable;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }


        public DataTable GetInCompletedOrdersDetails()
        {
            DataTable ordersTable = new DataTable();
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = @"
            SELECT 
                users.name AS UserName, 
                
                  
                 products.productname AS ProductName, 
                 products.category AS ProductCategory, 
                 products.brand AS ProductBrand, 
                  products.size AS ProductSize,
                  orders.orderid,
                 orders.Quantity, 
                 orders.address AS ShippingAddress, 
                 orders.TotalPrice,
	             orders.status
                FROM 
                  orders
                INNER JOIN 
                users ON orders.UserId = users.id
                 INNER JOIN 
                 products ON orders.ProductId = products.productid
                 WHERE 
                 orders.status = 'Completed';";

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(comm);
                adapter.Fill(ordersTable);

                return ordersTable;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public bool UpdateOrderStatus()
        {
            string newStatus = "Completed";

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "UPDATE orders SET status = @NewStatus WHERE OrderId = @OrderId";
                comm.Parameters.AddWithValue("@NewStatus", newStatus);
                comm.Parameters.AddWithValue("@OrderId", this.orderId);
                comm.ExecuteNonQuery();
                Console.WriteLine("Order status updated successfully.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }



        public bool InsertProduct()
        {

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "INSERT INTO Products ( ProductName, Category, Brand, Size, Quantity, Price) VALUES (@ProductName,@Category,@Brand, @Size, @Quantity,@Price)";
                comm.Parameters.AddWithValue("@ProductName", this.ProductName);
                comm.Parameters.AddWithValue("@Category", this.catogry);
                comm.Parameters.AddWithValue("@Brand", this.Brand);
                comm.Parameters.AddWithValue("@Size", this.Size);
                comm.Parameters.AddWithValue("@Quantity", this.Quantity);
                comm.Parameters.AddWithValue("@Price", this.Price);
                comm.ExecuteNonQuery();
                Console.WriteLine("added");
                return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }

            return false;
        }

        public int GetProductQuantity(int productId)
        {
            int quantity = 0;

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT quantity FROM products WHERE productid = @ProductId";
                comm.Parameters.AddWithValue("@ProductId", productId);

                object result = comm.ExecuteScalar();
                if (result != null)
                {
                    quantity = Convert.ToInt32(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }

            return quantity;
        }
        public bool UpdateProductQuantity(int productId, int newQuantity)
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "UPDATE products SET quantity = @NewQuantity WHERE productid = @ProductId";
                comm.Parameters.AddWithValue("@NewQuantity", newQuantity);
                comm.Parameters.AddWithValue("@ProductId", productId);

                int rowsAffected = comm.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Quantity updated successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine("ProductId not found or no changes made.");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
        }

        public (int productId, int quantity) GetProductAndQuantityFromOrder()
        {
            int productId = 0;
            int quantity = 0;

            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();

            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT ProductId, Quantity FROM orders WHERE OrderId = @OrderId";
                comm.Parameters.AddWithValue("@OrderId", this.orderId);

                NpgsqlDataReader reader = comm.ExecuteReader();

                if (reader.Read())
                {
                    productId = Convert.ToInt32(reader["ProductId"]);
                    quantity = Convert.ToInt32(reader["Quantity"]);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }

            return (productId, quantity);
        }

        public bool UpdateProduct()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "UPDATE Products SET ProductName = @productName, Category = @category, Brand = @brand, Size = @size, Quantity = @quantity, Price = @price WHERE ProductName = @productName";
                
                comm.Parameters.AddWithValue("@productName", this.ProductName);
                comm.Parameters.AddWithValue("@category", this.catogry);
                comm.Parameters.AddWithValue("@brand", this.Brand);
                comm.Parameters.AddWithValue("@size", this.Size);
                comm.Parameters.AddWithValue("@quantity", this.Quantity);
                comm.Parameters.AddWithValue("@price", this.Price);

                comm.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
                
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }


            return false;
        }

        public bool DeleteProduct()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "DELETE from Products where ProductName=@ProductName";
                comm.Parameters.AddWithValue("@ProductName", this.ProductName);

                comm.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {


                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }


            return false;


        }


        public double GetProductPrice()
        {
            double price = 0;
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            NpgsqlCommand comm = new NpgsqlCommand();
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select price from Products where productid=@Productid";
                comm.Parameters.AddWithValue("@Productid", this.Productid);

                
                object result = comm.ExecuteScalar();
                if (result != null)
                {
                    
                    price = Convert.ToDouble(result);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                comm.Dispose();
                conn.Close();
            }
            return price;
        }
    }
}
