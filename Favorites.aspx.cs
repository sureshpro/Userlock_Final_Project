using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Userlock_210323
{
    public partial class Favorites : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewAddFavorites1();
        }
        public void viewAddFavorites1()
        {
            // It is a user profile code once user authenticated then they can add the favorites to his page

            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                string DB1ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection1"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(DB1ConnectionString);

                string uname = User.Identity.Name.Split('\\')[1].ToString();
                if (uname == "bharathkumar.k")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from bharathkumar_k_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "dhineshkumar.s")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from dhineshkumar_s_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "john.jesudas")
                {
                     sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from john_jesudas_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "pragathieswaran.s")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from pragathieswaran_s_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "rajthilak.murugan")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from rajthilak_murugan_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "ruban.manokaran")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from ruban_manokaran_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "suresh.mohan")
                {
                   sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from suresh_mohan_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "vignesh.kumar")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from vignesh_kumar_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "amudha.ekambaram")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from amudha_ekambaram_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "challa.kalpana")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from challa_kalpana_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "Shyju.cv")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from shyju_cv_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "mugundhan.kanniappan")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from mugundhan_kanniappan_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "saabirahamed.ss")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from saabirahamed_ss_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "mary.john")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from mary_john_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "hemalatha.rajagopal")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from hemalatha_rajagopal_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "kalaivani.baskaran")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from kalaivani_baskaran_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "jancy.saravana")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from jancy_saravana_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "dinesh.arumugam")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from dinesh_arumugam_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "gopinath.ramachandra")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from gopinath_ramachandran_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "kannadasan.sokkaling")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from kannadasan_sokkalingam_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "rajesh.anbu")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from rajesh_anbu_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "saranya.raja")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from saranya_raja_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "sasidharan.mahendran")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from sasidharan_mahendran_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "shanmugapriya.gopina")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from shanmugapriya_gopinathan_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "bhagyalakshmi.dass")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from bhagyalakshmi_dass_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "muralitharan.c")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from muralitharan_c_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "mohamed.arif")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from mohamed_arif_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "harish.gopal")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from harish_gopal_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "arjun.venugopal")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from arjun_venugopal_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "vinothkumar.d")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from vinothkumar_d_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "prakash.rangaraju")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from prakash_rangaraju_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "valli.thiagarajan")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from valli_thiagarajan_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "sathishkumar.s")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from sathishkumar_s_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "vidhya.kothandanaidu")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from vidhya_kothandanaidu_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "sujith.r")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from sujith_r_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "vinoth.raja")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from vinoth_raja_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "hariharan.subramanian")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from hariharan_subramanian_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "vijayachandar.chandr")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from vijayachandar_chandrasekar_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "Archana.Subramani")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from archana_subramani_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else if (uname == "karthick.venkatesan")
                {
                    sqlconn.Open();
                    SqlCommand sqlcomm = new SqlCommand("select distinct max(ID) as ID,Name,Status,EventTime,Device from karthick_venkatesan_addFavorites group by Name,Status,EventTime,Device order by ID", sqlconn);
                    sqlcomm.CommandType = CommandType.Text;
                    sqlcomm.ExecuteNonQuery();
                    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
                    DataTable dt1 = new DataTable();
                    sdr.Fill(dt1);
                    Grid2.DataSource = dt1;
                    Grid2.DataBind();
                    sqlconn.Close();
                }
                else
                {
                    Grid2.Visible = false;
                }
        }
          
        }

        protected void Btn_Refresh_Click(object sender, EventArgs e)
        {
           /* viewAddFavorites1();*/
        }

        protected void LinkBtn_Delete_Click1(object sender, EventArgs e)
        {

            int rowindex = ((GridViewRow)((Control)sender).NamingContainer).RowIndex;
            int colindex = Convert.ToInt32(Grid2.Rows[rowindex].Cells[1].Text);

            string uname = User.Identity.Name.Split('\\')[1].ToString();

            string DB1ConnectionString = ConfigurationManager.ConnectionStrings["Myconnection1"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(DB1ConnectionString);
            {
                sqlconn.Open();
                if (uname == "bharathkumar.k")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from bharathkumar_k_addFavorites where ID = '" + colindex+"' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "dhineshkumar.s")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from dhineshkumar_s_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "john.jesudas")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from john_jesudas_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "pragathieswaran.s")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from pragathieswaran_s_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "rajthilak.murugan")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from rajthilak_murugan_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "ruban.manokaran")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from ruban_manokaran_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "suresh.mohan")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from suresh_mohan_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "vignesh.kumar")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from vignesh_kumar_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "amudha.ekambaram")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from amudha_ekambaram_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "challa.kalpana")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from challa_kalpana_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "Shyju.cv")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from shyju_cv_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "mugundhan.kanniappan")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from mugundhan_kanniappan_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "saabirahamed.ss")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from saabirahamed_ss_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "mary.john")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from mary_john_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "hemalatha.rajagopal")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from hemalatha_rajagopal_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "kalaivani.baskaran")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from kalaivani_baskaran_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "jancy.saravana")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from jancy_saravana_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "dinesh.arumugam")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from dinesh_arumugam_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "gopinath.ramachandra")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from gopinath_ramachandran_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "kannadasan.sokkaling")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from kannadasan_sokkalingam_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "rajesh.anbu")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from rajesh_anbu_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "saranya.raja")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from saranya_raja_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "sasidharan.mahendran")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from sasidharan_mahendran_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "shanmugapriya.gopina")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from shanmugapriya_gopinathan_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "bhagyalakshmi.dass")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from bhagyalakshmi_dass_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "muralitharan.c")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from muralitharan_c_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "mohamed.arif")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from mohamed_arif_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "harish.gopal")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from harish_gopal_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "arjun.venugopal")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from arjun_venugopal_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "vinothkumar.d")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from vinothkumar_d_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "prakash.rangaraju")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from prakash_rangaraju_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }               
                else if (uname == "valli.thiagarajan")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from valli_thiagarajan_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "sathishkumar.s")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from sathishkumar_s_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "vidhya.kothandanaidu")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from vidhya_kothandanaidu_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "sujith.r")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from sujith_r_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "vinoth.raja")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from vinoth_raja_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "hariharan.subramanian")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from hariharan_subramanian_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "vijayachandar.chandr")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from vijayachandar_chandrasekar_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "Srchana.Subramani")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from archana_subramani_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }
                else if (uname == "karthick.venkatesan")
                {
                    SqlCommand sqlcomm = new SqlCommand("Delete from karthick_venkatesan_addFavorites where ID = '" + colindex + "' ", sqlconn);
                    sqlcomm.ExecuteNonQuery();
                }



                sqlconn.Close();
                viewAddFavorites1();
            }
        }

     


    }
}
