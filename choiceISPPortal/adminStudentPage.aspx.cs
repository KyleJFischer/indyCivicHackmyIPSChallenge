using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class adminStudentPage : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        
    }
    static System.Data.DataTable GetTable()
    {
        // Here we create a DataTable with four columns.
        DataTable table = new DataTable();
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("Last", typeof(string));
        table.Columns.Add("First", typeof(string));
        table.Columns.Add("Date", typeof(DateTime));

        // Here we add five DataRows.
        table.Rows.Add(25, "Lutz", "David", DateTime.Now);
        table.Rows.Add(50, "Fischer", "Sam", DateTime.Now);
        table.Rows.Add(10, "Fred", "Christoff", DateTime.Now);
        table.Rows.Add(21, "Smith", "Janet", DateTime.Now);
        table.Rows.Add(100, "Pradhan", "Melanie", DateTime.Now);
        return table;
    }
}