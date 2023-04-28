using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Services;
using System.Drawing;


namespace Userlock_210323
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // set the default mode
                ViewState["mode"] = "light";
            }
        }
        [WebMethod]
        public static List<string> GetEmp(string empdetails)
        {
            // this is Autocomplete code for the textbox search
            List<string> emp = new List<string>();

            // get the connection string from the configuration file
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = string.Format("select distinct UserFullName,UserAccount from UserLogonEvents where UserAccount LIKE '%{0}%'", empdetails);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            while (sdr.Read())
            {
                emp.Add(sdr.GetString(0));
            }
            sqlconn.Close();
            return emp;
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            // this code is used to view employee status in grid view format 

            // get the connection string from the configuration file 

            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand("SELECT temp.[UserFullName] AS[Name], CASE WHEN[temp].[EventType] = 0 THEN 'Offline' WHEN[temp].[EventType] = 1 THEN 'Online' WHEN[temp].[EventType] = 2 THEN 'Away' WHEN[temp].[EventType] = 3 THEN 'Online' WHEN[temp].[EventType] = 4 THEN 'Others' WHEN[temp].[EventType] = 5 THEN 'Online' WHEN[temp].[EventType] = 6 THEN 'Offline' END as Status, temp.[EventTime] AS[Event Time], temp.[Device] FROM (SELECT TOP 1 EventType, EVENTTIME, USERFULLNAME, ComputerName as DEVICE FROM UserLogonEvents WHERE UserFullName = @UserFullName ORDER BY EventTime DESC) temp", sqlconn);
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.Parameters.AddWithValue("@UserFullName", TextBox1.Text);
            sqlcomm.ExecuteNonQuery();


            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt1 = new DataTable();
            sdr.Fill(dt1);
            Grid1.DataSource = dt1;
            Grid1.DataBind();

            // this code is used to showing the colors for status in each circle buttons

            SqlDataReader readed;
            readed = sqlcomm.ExecuteReader();
            if (readed.Read())
            {
                //before we searching the users details it should be gray color

                Btn_green.BackColor = Color.Gray;
                Btn_yellow.BackColor = Color.Gray;
                Btn_red.BackColor = Color.Gray;

                // the Column EventType = status so status == 0 is Offline and some related if statements below
                // Get the value of the "Status" key from the data source and convert it to a string

                string status = readed["Status"].ToString();

                // Check the value of the status variable and set the background color of the appropriate button
                if (status == "Online")
                {
                    Btn_green.BackColor = Color.Green;

                }
                else if (status == "Away")
                {
                    Btn_yellow.BackColor = Color.Yellow;
                }
                else if (status == "Offline")
                {
                    Btn_red.BackColor = Color.Red;
                }
            }
            else
            {


            }
            sqlconn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            foreach (GridViewRow row in Grid1.Rows)
            {
                string DB1ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection1"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(DB1ConnectionString);
                sqlconn.Open();
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    string uname = User.Identity.Name.Split('\\')[1].ToString();
                    if (uname == "suresh.mohan")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into suresh_mohan_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "john.jesudas")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into john_jesudas_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "vignesh.kumar")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into vignesh_kumar_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "bharathkumar.k")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into bharathkumar_k_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "rajthilak.murugan")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into rajthilak_murugan_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "ruban.manokaran")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into ruban_manokaran_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "pragathieswaran.s")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into pragathieswaran_s_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "dhineshkumar.s")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into dhineshkumar_s_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "amudha.ekambaram")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into amudha_ekambaram_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "challa.kalpana")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into challa_kalpana_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "Shyju.cv")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into shyju_cv_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "mugundhan.kanniappan")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into mugundhan_kanniappan_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "saabirahamed.ss")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into saabirahamed_ss_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "mary.john")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into mary_john_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "hemalatha.rajagopal")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into hemalatha_rajagopal_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "kalaivani.baskaran")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into kalaivani_baskaran_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "jancy.saravana")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into jancy_saravana_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "dinesh.arumugam")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into dinesh_arumugam_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "gopinath.ramachandra")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into gopinath_ramachandran_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }                   
                    else if (uname == "kannadasan.sokkaling")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into kannadasan_sokkalingam_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "rajesh.anbu")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into rajesh_anbu_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "saranya.raja")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into saranya_raja_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "sasidharan.mahendran")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into sasidharan_mahendran_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "shanmugapriya.gopina")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into shanmugapriya_gopinathan_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "bhagyalakshmi.dass")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into bhagyalakshmi_dass_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "muralitharan.c")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into muralitharan_c_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "mohamed.arif")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into mohamed_arif_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "harish.gopal")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into harish_gopal_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "arjun.venugopal")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into arjun_venugopal_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "vinothkumar.d")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into vinothkumar_d_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "prakash.rangaraju")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into prakash_rangaraju_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "valli.thiagarajan")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into valli_thiagarajan_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "sathishkumar.s")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into sathishkumar_s_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "vidhya.kothandanaidu")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into vidhya_kothandanaidu_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "sujith.r")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into sujith_r_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "vinoth.raja")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into vinoth_raja_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "hariharan.subramanian")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into hariharan_subramanian_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "vijayachandar.chandr")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into vijayachandar_chandrasekar_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "Archana.Subramani")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into archana_subramani_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else if (uname == "karthick.venkatesan")
                    {
                        SqlCommand sqlcomm = new SqlCommand("insert into karthick_venkatesan_addFavorites values('" + row.Cells[0].Text + "', '" + row.Cells[1].Text + "','" + row.Cells[2].Text + "','" + row.Cells[3].Text + "') ", sqlconn);
                        sqlcomm.CommandType = CommandType.Text;
                        sqlcomm.ExecuteNonQuery();
                    }
                    else
                    {
                        Response.Write("Unable To Use");
                    }

                }
                
                sqlconn.Close();
            }

            if (string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                Click.Text = "Please enter a value!";
                
            }
            else
            {
               
                Click.Text = "Record saved successfully!";
            }
        }
    }
}
