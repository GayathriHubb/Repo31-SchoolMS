using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMS
{
    internal class StudentsData
    {
        public StudentsData() { }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SchoolMS\School.mdf;Integrated Security=True";

        public int Id { get; set; }
        public string StudentId { get; set; }  // 1 
        public string Name { get; set; } // 2
        public string Gender { get; set; } // 3
        public string Address { get; set; } // 4
        public string Class {  get; set; } // 5
        public string Section { get; set; } // 6
        public string Status { get; set; } // 7
        public string ImagePath { get; set; } // 8
        public string DateInsert { get; set; } // 9
        public string DateUpdate { get; set; } // 10

        public List<StudentsData> ListStudents()
        {
            List<StudentsData> stdslist = new List<StudentsData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Students Where DateDelete is NULL";

                    using (SqlCommand sqlcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = sqlcmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            StudentsData stds = new StudentsData();

                            stds.Id = (int)sdr["Id"];
                            stds.StudentId = (string)sdr["StudentId"];
                            stds.Name = (string)sdr["StudentName"];
                            stds.Gender = (string)sdr["Gender"];
                            stds.Address = (string)sdr["Address"];
                            stds.Class = (string)sdr["Class"];
                            stds.Section = (string)sdr["Section"];
                            stds.Status = (string)sdr["Status"];
                            stds.ImagePath = (string)sdr["ImagePath"];
                            stds.DateInsert = (Convert.ToDateTime(sdr["DateInsert"])).ToString("dd-MM-yyyy");
                            stds.DateUpdate = (sdr["DateUpdate"] == DBNull.Value) ? null : (Convert.ToDateTime(sdr["DateUpdate"])).ToString("dd-MM-yyyy");
                            
                            stdslist.Add(stds);
                        }
                    }
                }
                catch (Exception ex) 
                { 
                    Debug.WriteLine(ex.Message, "StudentsData");
                }

            }

            return stdslist;
        }

        public List<StudentsData> ListEnrStdsTod()
        {
            List<StudentsData> stdslist = new List<StudentsData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Students Where Status = @status AND DateInsert = @dtins AND DateDelete is NULL";

                    using (SqlCommand sqlcmd = new SqlCommand(seldata, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@status", "Enrolled");
                        sqlcmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                        SqlDataReader sdr = sqlcmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            StudentsData stds = new StudentsData();

                            stds.Id = (int)sdr["Id"];
                            stds.StudentId = (string)sdr["StudentId"];
                            stds.Name = (string)sdr["StudentName"];
                            stds.Gender = (string)sdr["Gender"];
                            stds.Address = (string)sdr["Address"];
                            stds.Class = (string)sdr["Class"];
                            stds.Section = (string)sdr["Section"];
                            stds.Status = (string)sdr["Status"];
                            stds.ImagePath = (string)sdr["ImagePath"];
                            stds.DateInsert = (Convert.ToDateTime(sdr["DateInsert"])).ToString("dd-MM-yyyy");
                            stds.DateUpdate = (sdr["DateUpdate"] == DBNull.Value) ? null : (Convert.ToDateTime(sdr["DateUpdate"])).ToString("dd-MM-yyyy");

                            stdslist.Add(stds);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "StudentsData");
                }

            }

            return stdslist;

        }

    }
}
