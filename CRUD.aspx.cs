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
            SqlCommand cmd = new SqlCommand("select * from Workers where id=@id", con);
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

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Workers values ( @name, @age, @gender)", con);
            cmd.Parameters.Add(new SqlParameter("@name", TextBoxName.Text));
            cmd.Parameters.Add(new SqlParameter("@age", TextBoxAge.Text));
            cmd.Parameters.Add(new SqlParameter("@gender", TextBoxGender.Text));

            int x = cmd.ExecuteNonQuery();
            LabelStatus.Text = x + "rows successfully added!";
        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Workers set name=@name, age=@age, gender=@gender where id=@id",con);
            cmd.Parameters.Add(new SqlParameter("@id", TextBoxID.Text));
            cmd.Parameters.Add(new SqlParameter("@name", TextBoxName.Text));
            cmd.Parameters.Add(new SqlParameter("@age", TextBoxAge.Text));
            cmd.Parameters.Add(new SqlParameter("@gender", TextBoxGender.Text));

            int c = cmd.ExecuteNonQuery();
            LabelStatus.Text = c + " rows successfully updated!";

        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Workers where id=@id", con);
            cmd.Parameters.Add(new SqlParameter("@id", TextBoxID.Text));

            int v = cmd.ExecuteNonQuery();
            LabelStatus.Text = v + " rows successfully deleted!";
        }

        protected void ButtonClearData_Click(object sender, EventArgs e)
        {
            TextBoxID.Text = String.Empty;
            TextBoxName.Text = String.Empty;
            TextBoxAge.Text = String.Empty;
            TextBoxGender.Text = String.Empty;
        }
    }
}