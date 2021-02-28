using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet_Practice
{
    public static class MyModel
    {
        public static bool Write_DB(Person person)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=mssql;Initial Catalog=shepel_db;User Id=student;Integrated Security=False"))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(@"INSERT INTO [dbo].[Water]([Weight], [Type], [Sex]) VALUES(@p_weight, @p_type, @p_sex);", connection))
                    {
                        SqlParameter weightParameter = new SqlParameter("@p_weight", person.weight);
                        SqlParameter typeParameter = new SqlParameter("@p_type", person.type);
                        SqlParameter sexParameter = new SqlParameter("@p_sex", person.sex);

                        command.Parameters.AddRange(new SqlParameter[] { weightParameter, typeParameter, sexParameter });

                        int count = command.ExecuteNonQuery();
                        command.Dispose();
                        connection.Close();
                        if (count > 0)
                            return true;

                        return false;
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
    }
}
