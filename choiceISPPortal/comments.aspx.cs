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
using System

public partial class comments : System.Web.UI.Page
{
    int applicationID = 0;
    int curViewerId = 0;
    int appId = 0;
    int parentID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Load Overall Comments
        
        
    }

    protected void loadComments(){

    }
   

    protected void addComment(string userName, string msg)
    {

        using (SqlConnection cn = new SqlConnection("Data source=(local); Initial Catalog=INT422Assignment1; Integrated Security=SSPI;"))
        using (SqlCommand cmd = cn.CreateCommand())
        {


            cmd.CommandText = "Insert into Communication (applicationID, timeStamp, msgLog, parentID) VALUES (@applicationID, @timeStamp, @msgLog, @parentID)";

            cmd.Parameters.AddWithValue("@applicationID", applicationID);
            cmd.Parameters.AddWithValue("@timeStamp", DateTime.Now);
            cmd.Parameters.AddWithValue("@msgLog", msg);
            cmd.Parameters.AddWithValue("@parentID", parentID);

            cn.Open();

            
            cmd.ExecuteNonQuery();

            cn.Close();

        }

        

       
    }
}