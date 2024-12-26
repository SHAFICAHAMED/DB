using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace DB
{
    public partial class myform : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|mydb.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            disp_data();
        }

        protected void ins_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType=CommandType.Text;
            //cmd.CommandText = "insert into det values('" + firstname.Text+"','"+age.Text+"','"+lastname.Text+"')";
            cmd.CommandText = "insert into stu values('" + firstname.Text + "')";
            cmd.ExecuteNonQuery();
            firstname.Text = "";
            age.Text = "";
            lastname.Text = "";
            disp_data();
        }
        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from stu";
            cmd.ExecuteNonQuery();
            DataTable dt=new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void del_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from det where firstName='"+firstname.Text+"'";
            cmd.ExecuteNonQuery();
            firstname.Text = "";
           
            disp_data();
        }

        protected void upd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update det set firstName='"+firstname.Text+"', age='"+age.Text+"', lastName='"+lastname.Text+"'where id="+Convert.ToInt32(idold.Text)+"";
            cmd.ExecuteNonQuery();
            firstname.Text = "";
            age.Text = "";
            lastname.Text = "";
            disp_data();
        }

        protected void vie_Click(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}