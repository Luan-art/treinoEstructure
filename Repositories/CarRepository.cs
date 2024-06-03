using Microsoft.Data.SqlClient;
using Microsoft.Win32.SafeHandles;
using Models;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Repositories
{
    public class CarRepository
    {
        string strConn = "Data Source=127.0.0.1; Initial Catalog=projAula2; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
        SqlConnection conn;

        public CarRepository()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        public bool Insert(Car car)
        {
            bool result = false;

            try
            {

                SqlCommand cmd = new SqlCommand(car.Insert, conn);

                cmd.Parameters.Add(new SqlParameter("@Name", car.name));
                cmd.Parameters.Add(new SqlParameter("@Color", car.color));
                cmd.Parameters.Add(new SqlParameter("@Year", car.year));
                cmd.Parameters.Add(new SqlParameter("@insurenceId", car.insurance.id));

                cmd.ExecuteNonQuery();

                result = true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return result;

            } finally { conn.Close(); }
            
            return result;
        }

        public bool Update(Car car)
        {
            bool result = false;

            try
            {
 
                SqlCommand cmd = new SqlCommand(car.Update, conn);

                cmd.Parameters.Add(new SqlParameter("@Name", car.name));
                cmd.Parameters.Add(new SqlParameter("@Color", car.color));
                cmd.Parameters.Add(new SqlParameter("@Year", car.year));
                cmd.Parameters.Add(new SqlParameter("@id", car.id));


                cmd.ExecuteNonQuery();

                result = true;
            }
            catch (Exception ex)
            {
                return result;

            }
            finally { conn.Close(); }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;

            try
            {
                
                SqlCommand cmd = new SqlCommand(new Car().Delete, conn);

                cmd.Parameters.Add(new SqlParameter("@id", id));


                if (cmd.ExecuteNonQuery() > 0) result = true;

            }
            catch (Exception ex)
            {
                return result;

            }
            finally { conn.Close(); }

            return result;
        }

        public List<Car> GetAll()
        {
            List<Car> list = new List<Car>();

            StringBuilder sb = new StringBuilder();

                
            sb.Append(new Car().GetAll);
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Car car = new Car();
                    car.id = reader.GetInt32(0);
                    car.name = reader.GetString(1);
                    car.color = reader.GetString(2);
                    car.year = reader.GetInt32(3);

                    list.Add(car);
                }

            } catch(Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return list;
        }

        public Car? Get(int id)
        {
            {
                Car? car = null;

                StringBuilder sb = new StringBuilder();

                sb.Append(new Car().Get);
                try
                {
                    SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        car = new Car();
                        car.id = reader.GetInt32(0);
                        car.name = reader.GetString(1);
                        car.color = reader.GetString(2);
                        car.year = reader.GetInt32(3);
                    }

                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }

                return car;
            }
        }
    }
}
