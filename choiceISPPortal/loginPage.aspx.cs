using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Web.UI.WebControls;
using System.IO;
using System.Object;


public partial class loginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    static bool IsAuthenticated(string uid, string pwd)
    {
        if (string.IsNullOrWhiteSpace(uid)) throw new ArgumentNullException("uid");
        if (string.IsNullOrWhiteSpace(pwd)) throw new ArgumentNullException("pwd");

        bool authenticated;

        using (SqlConnection cn = new SqlConnection("Data source=(local); Initial Catalog=INT422Assignment1; Integrated Security=SSPI;"))
        using (SqlCommand cmd = cn.CreateCommand())
        {

            
            cmd.CommandText = @"SELECT parents = count(*) FROM myLogin WHERE userNameTB = @usernameAND passWordTB = @pwd";

            cmd.Parameters.AddWithValue("@username", uid);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            cn.Open();

            authenticated = ((int)cmd.ExecuteScalar()) > 0 ? true : false;
            cmd.ExecuteNonQuery();

            cn.Close();

        }

        return authenticated;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool success = IsAuthenticated(TextBox1.Text, TextBox2.Text);

        if (success)
        {
            bool adminTest = false;
            //Check if Admin
            //Redirect to admin page
            if (adminTest)
            {
                //save id and admin priveledges
                //redirect to admin page
            }
            else
            {
                //Save id
                //redirect to parent page from id
                
            }
            
        } 
    }
}