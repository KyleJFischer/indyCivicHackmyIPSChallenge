using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Web.UI.WebControls;


public partial class studentRegister : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void createStudent(string studentFirst, string studentLast, string Street, string city, string state, string ZIP, DateTime dob, string gender, Boolean IEP, string race, string ethnicity, string prefLanguage, int curGrade, string curSchool, int siblingId, string PerformingArts)
    {
        SqlConnection openCon = new SqlConnection("HELLOWORLD");
        string command = "INSERT into studentTable (studentFirst, studentLast, street, city, state, zip, dob, gender, iep, race, ethnicity, prefLanguage, curGrade, curSchool, siblingID, performingArts)" + 
            " VALUES (@studentFirst, @studentLast, @street, @city, @state, @zip, @dateOfBirth, @Gender, @IEP, @race, @ethnictiy, @prefLanguage, @curGrade, @curSchool, @siblingID, @performingArts)";
        SqlCommand insertCommand = new SqlCommand(command);
        insertCommand.Connection = openCon;
        insertCommand.Parameters.AddWithValue("@studentFirst", studentFirst);
        insertCommand.Parameters.AddWithValue("@studentLast", studentLast);
        insertCommand.Parameters.AddWithValue("@street", Street);
        insertCommand.Parameters.AddWithValue("@city", city);
        insertCommand.Parameters.AddWithValue("@state", state);
        insertCommand.Parameters.AddWithValue("@zip", ZIP);
        insertCommand.Parameters.AddWithValue("@dob", dob);
        insertCommand.Parameters.AddWithValue("@gender", gender);
        insertCommand.Parameters.AddWithValue("@IEP", IEP);
        insertCommand.Parameters.AddWithValue("@race", race);
        insertCommand.Parameters.AddWithValue("@ethnicity", ethnicity);
        insertCommand.Parameters.AddWithValue("@prefLanguage", prefLanguage);
        insertCommand.Parameters.AddWithValue("@curGrade", curGrade);
        insertCommand.Parameters.AddWithValue("@curSchool", curSchool);
        insertCommand.Parameters.AddWithValue("@siblingID", siblingId);
        insertCommand.Parameters.AddWithValue("@performingArts", PerformingArts);

        openCon.Open();
        insertCommand.ExecuteNonQuery();
        openCon.Close();

    }

    protected void msgBox(string title, string messge)
    {

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}