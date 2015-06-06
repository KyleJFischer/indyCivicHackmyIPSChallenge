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


public partial class docsPage : System.Web.UI.Page
{
    int studID = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile == true)
        {
            SqlConnection openCon = new SqlConnection("HELLOWORLD");
            string command = "INSERT into docTable (studentID, File, FileType, fileExtension) VALUES (@studentID, @file, @fileType, @fileExtension)";
            SqlCommand insertCommand = new SqlCommand(command);
            insertCommand.Connection = openCon;
            insertCommand.Parameters.AddWithValue("@studentID", studID);
            insertCommand.Parameters.AddWithValue("@file", FileUpload1.FileContent);
            insertCommand.Parameters.AddWithValue("@fileType", DropDownList1.Text);
            insertCommand.Parameters.AddWithValue("@fileExtension", Path.GetExtension(FileUpload1.FileName));

            openCon.Open();
            insertCommand.ExecuteNonQuery();
            openCon.Close();
        }
        else
        {
            
        }
    }
    protected string tempFileFunction(string file)
    {
        
        return null;
    }
}