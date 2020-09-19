using System;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace onlineexam
{
    public partial class online : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string maincon = ConfigurationManager.ConnectionStrings["Mycon"].ConnectionString;
                SqlConnection sqlcon = new SqlConnection(maincon);
                string sqlquerry = "select * from onlineexam";


                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(sqlquerry, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                sqlcon.Close();



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb1 = (RadioButton)ri.FindControl("RadBtn1");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                labcorrectans.Visible = true;
                
                if (rb1.Checked)
                {
                    
                    if (rb1.Text.Equals(labcorrectans.Text))
                    {
                        count = count + 1;
                        Label Userselectans = (Label)ri.FindControl("User");
                        Userselectans.Text = "The Selected Anwer is" + rb1.Text.ToString();
                        Userselectans.ForeColor = System.Drawing.Color.Green;
                      
                    }
                    else
                    {
                        Label Wrongans = (Label)ri.FindControl("User");
                       
                        Wrongans.Text = "The Selected Anwer  " + rb1.Text.ToString() + " is wrong";
                        Wrongans.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

            
            foreach (RepeaterItem ri in Repeater1.Items)
            {

                RadioButton rb2 = (RadioButton)ri.FindControl("RadBtn2");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");

                labcorrectans.Visible = true;
                if (rb2.Checked)
                {
                    if (rb2.Text.Equals(labcorrectans.Text))
                    {
                        count = count + 1;
                        Label Userselectans = (Label)ri.FindControl("User");
                        Userselectans.Text = "The Selected Anwer is" + rb2.Text.ToString();
                        Userselectans.ForeColor = System.Drawing.Color.Green;
                       
                    }
                    else
                    {
                        Label Wrongans = (Label)ri.FindControl("User");
                        Wrongans.Text = "The Selected Anwer  " + rb2.Text.ToString() + " is wrong";
                        Wrongans.ForeColor = System.Drawing.Color.Red;
                    }
                }

            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {

                RadioButton rb3 = (RadioButton)ri.FindControl("RadBtn3");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                labcorrectans.Visible = true;
                if (rb3.Checked)
                {

                    if (rb3.Text.Equals(labcorrectans.Text))
                    {
                        count = count + 1;
                        Label Userselectans = (Label)ri.FindControl("User");
                        Userselectans.Text = "The Selected Anwer is" + rb3.Text.ToString();
                        Userselectans.ForeColor = System.Drawing.Color.Green;
                        
                    }
                    else
                    {
                        Label Wrongans = (Label)ri.FindControl("User");
                        Wrongans.Text = "The Selected Anwer  "+ rb3.Text.ToString() + " is wrong";
                        Wrongans.ForeColor = System.Drawing.Color.Red;
                    }
                }

            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {

                RadioButton rb4 = (RadioButton)ri.FindControl("RadBtn4");
                Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");

                labcorrectans.Visible = true;
                if (rb4.Checked)
                {
                    if (rb4.Text.Equals(labcorrectans.Text))
                    {
                        count = count + 1;
                        Label Userselectans = (Label)ri.FindControl("User");
                        Userselectans.Text = "The Selected Anwer is " + rb4.Text.ToString();
                        Userselectans.ForeColor = System.Drawing.Color.Green;
                        
                    }
                    else
                    {

                        Label Wrongans = (Label)ri.FindControl("User");
                        Wrongans.Text = "The Selected Anwer  " + rb4.Text.ToString() + " is wrong";
                        Wrongans.ForeColor = System.Drawing.Color.Red;
                    }
                }
             

            }
            Response.Write("your score=" + count);
            /* int count = 0;

             foreach (RepeaterItem ri in Repeater1.Items)
             {

                 RadioButton r1 = (RadioButton)ri.FindControl("RadBtn1");
                 Label labcorrectans = (Label)ri.FindControl("LabCorrectAns");
                 RadioButton r2 = (RadioButton)ri.FindControl("RadBtn2");
                 RadioButton r3 = (RadioButton)ri.FindControl("RadBtn3");
                 RadioButton r4 = (RadioButton)ri.FindControl("RadBtn4");


                 if (r1.Checked==true)
                 {

                     if (r1.Text.Equals(labcorrectans.Text))
                     {
                         count = count + 1;
                     }

                 }
                 else if(r2.Checked==true)
                 {
                     Response.Write("in r1");
                     if (r2.Text.Equals(labcorrectans.Text))
                     {
                         count = count + 1;
                     }
                 }

                 else if (r3.Checked == true)
                 {
                     Response.Write("in r1");
                     if (r3.Text.Equals(labcorrectans.Text))
                     {
                         count = count + 1;
                     }
                 }
                 else if (r4.Checked == true)
                 {
                     Response.Write("in r1");
                     if (r4.Text.Equals(labcorrectans.Text))
                     {
                         count = count + 1;
                     }
                 }
                 else
                 {
                     Response.Write("not select");
                 }



             }


             Response.Write("your score=" + count);*/
        }

        }   
    }


    
    

