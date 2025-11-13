using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMS
{
    internal class TeachersData
    {
        public TeachersData() { }

        readonly string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\SchoolMS\School.mdf;Integrated Security=True";

        public int Id { get; set; }
        public string TeacherId { get; set; } // 1
        public string Name { get; set; } // 2
        public string Gender { get; set; } // 3
        public string Address { get; set; } // 4
        public string PhnNum { get; set; } // 5
        public string Subject { get; set; } // 6
        public int Salary { get; set; } // 7
        public string Status { get; set; } // 8
        public string ImagePath { get; set; } // 9
        public string DateInsert { get; set; } // 10
        public string DateUpdate { get; set; } // 11

        public List<TeachersData> ListTeachers()
        {
            List<TeachersData> tchslist = new List<TeachersData>();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Teachers Where DateDelete is NULL";

                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            TeachersData tchs = new TeachersData();

                            tchs.Id = (int)sdr["Id"];
                            tchs.TeacherId = (string)sdr["TeacherId"];
                            tchs.Name = (string)sdr["TeacherName"];
                            tchs.Gender = (string)sdr["Gender"];
                            tchs.Address = (string)sdr["Address"];
                            tchs.PhnNum = (string)sdr["PhnNum"];
                            tchs.Subject = (string)sdr["Subject"];
                            tchs.Salary = (int)sdr["Salary"];
                            tchs.Status = (string)sdr["Status"];
                            tchs.ImagePath = (string)sdr["ImagePath"];
                            tchs.DateInsert = (Convert.ToDateTime(sdr["DateInsert"])).ToString("dd-MM-yyyy");
                            tchs.DateUpdate = (sdr["DateUpdate"] == DBNull.Value) ? null : (Convert.ToDateTime(sdr["DateUpdate"])).ToString("dd-MM-yyyy");

                            tchslist.Add(tchs);

                        }
                    }

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "TeachersData");
                }
            }

            return tchslist;
        }

    }
}

    

    
