﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class NextPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TextBox1.Text))
            {
                Label1.Text = "Welcome, " + Server.HtmlEncode(TextBox1.Text) + "<br/> The url is " + Server.UrlEncode(Request.Url.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}