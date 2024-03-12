using MySql.Data.MySqlClient;

namespace ConsoleApp1; 
internal partial class Program
{
    public static void Ques14Demo()
    {
        // establish connection
        try {
            // a)
            string connectionString = "server=localhost; user=root; database=dotnet";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            // b)
            string sql = "select * from product where unitPrice > 5000";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine("productId | productName  | unitPrice");
            while(rdr.Read())
            {
                Console.WriteLine($"{rdr[0]} \t  | {rdr[1]}\t | {rdr[2]}");
            }
            rdr.Close();

            // c)
            sql = "update product set unitPrice = 10000 where productId = 11";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            // d)
            sql = "delete from product where productId = 22";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            // e)
            // productId is omitted because it is set to autoincrement
            sql = "insert into product(productName, unitPrice) values ('Monitor', 30000), ('Power Bank', 7000), ('Headphones', 4000)" ;
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();


            sql = "select * from product";
            cmd = new MySqlCommand(sql, conn);
            rdr = cmd.ExecuteReader();

            Console.WriteLine("New values are: ");
            Console.WriteLine("productId | productName  | unitPrice");
            while(rdr.Read()) {
                Console.WriteLine($"{rdr[0]} \t  | {rdr[1]}\t | {rdr[2]}");
            }
            rdr.Close();

            conn.Close();

        }
        catch (Exception ex)
        {
            // System.Diagnostics.Debugger.Break();
            Console.WriteLine(ex.Message);
        }


    }
}
