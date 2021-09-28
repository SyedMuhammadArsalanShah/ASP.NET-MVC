using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Traditional_approach_in_MVC_to_get_Table.Models
{
    public class TraditionalBusinessLayer
    {
      
            public IEnumerable<Student> Companies
            {
                get
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;


                    List<Student> companies = new List<Student>();


                    using (SqlConnection con = new SqlConnection(connectionString))
                    {

                        SqlCommand cmd = new SqlCommand("Select * from info ", con);

                        con.Open();
                        SqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            Student student = new Student();
                            student.Id = Convert.ToInt32(dataReader["Id"]);
                            student.Name = dataReader["Name"].ToString();
                            student.Cnic = dataReader["Cnic"].ToString();
                            companies.Add(student);

                        }

                    }


                    return companies;



                }

            }
        }



    }
