﻿//CRUD Operations using ADO.Net and C#. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DB_Connection.CRUD
{
    public partial class CRUD : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-GEEICOS\\sqlexpress;integrated security=true;database=MyDB");        
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Person where eid=@id", con);
            SqlParameter sp1 = new SqlParameter("@id", TextBoxID.Text);
            cmd.Parameters.Add(sp1);
            SqlDataReader dr1 = cmd.ExecuteReader();

            if(dr1.Read())
            {
                TextBoxName.Text = dr1[1].ToString();
                TextBoxAge.Text = dr1[2].ToString();
                TextBoxGender.Text = dr1[3].ToString();
            }

            else
            {
                LabelStatus.Text = "Sorry! Record not found!";
            }
        }
    }
}