using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Tech_UI
{
    public partial class FeedbackForm : Form
    {
        class TextSuggestion
        {
            public string shortCutDescription { get; set; }
            public string shortCutText { get; set; }
            
        }
        
        class Template
        {
            public string apptempdescription { get; set; }
            public string apptemptext { get; set; }
        }

        public FeedbackForm()
        {
            InitializeComponent();
            List<TextSuggestion> ft = new List<TextSuggestion>();
            List<Template> at = new List<Template>();
            ft.Add(new TextSuggestion() { shortCutDescription = "Greetings on CV-Match", shortCutText = "Congratulations! According to your CV, you seem to be on your track to being the right match for this position" });
            ft.Add(new TextSuggestion() { shortCutDescription = "Greetings on Examination", shortCutText = "Congratulations, You have passed the technical requirements!" });
            ft.Add(new TextSuggestion() { shortCutDescription = "Greetings on Interview Invitation", shortCutText = "Congratulations, You have reached the next stage of your application and are being officially invited for an interview!" });
            ft.Add(new TextSuggestion() { shortCutDescription = "Greetings on Acceptance", shortCutText = "Congratulations, You have been accepted for your applied position!" });
            ft.Add(new TextSuggestion() { shortCutDescription = "Apologies for CV-Match", shortCutText = "I regret to inform you that your CV did not match what we were looking for." });
            ft.Add(new TextSuggestion() { shortCutDescription = "Apologies for Examination", shortCutText = "I regret to inform you that your technical skill-base is not what we were looking for " });
            ft.Add(new TextSuggestion() { shortCutDescription = "Apologies for Interview Invitation", shortCutText = "I regret to inform you that you not progress to the next stage of the application process." });
            ft.Add(new TextSuggestion() { shortCutDescription = "Apologies for Rejection", shortCutText = "I regret to inform you that your applied position was not the right match for you" });
            ft.Add(new TextSuggestion() { shortCutDescription = "Thanking for their interest", shortCutText = "We appreciate your interest in our company and wish you success in your search!" });
            at.Add(new Template() { apptempdescription = "Programmer", apptemptext = "We have reviewed your application for a programmer, just so you are aware this role involves programming in c# and HTML so we want to ensure you are confident with those two at the minimum" });
            at.Add(new Template() { apptempdescription = "Software Engineer", apptemptext = "We have reviewed you application for a software engineer, we are looking for someone expierienced and confident in all the stages of software engineering development " });

            suggestedText.DataSource = ft;
            suggestedText.DisplayMember = "shortCutDescription";
            
            

            comboBox1.DataSource = at;
            comboBox1.DisplayMember = "apptempdescription";


        }
        

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                FeedbackText.Text = "Congratulation your application was Successful ";
                FeedbackText.Refresh();
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                FeedbackText.Text = "Sorry your application was Unsuccessful ";
                FeedbackText.Refresh();
            }
        }

        private void SendFeedback_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=USER; Initial Catalog=admin; Integrated Security=True"); // making connection 
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Feedback(Applicant_ID, User_ID, Feedback_Header, Comments) values ('" + RecipientOfFeedback.Text + "', '" + Interviewer.Text + "', '" + FeedbackTopic.Text + "', '" + FeedbackText.Text + "')", con); //inserting feedback-form values to the database

            //if some value is added (not equal to zero), then shows 'Email Send' and sends email
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Email Sent");
            }
            else
            {
                MessageBox.Show("Please complete the form");
            }
        }

        private void suggestedText_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextSuggestion ft1 = suggestedText.SelectedItem as TextSuggestion;
            FeedbackText.Text += ft1.shortCutText;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Template at1 = comboBox1.SelectedItem as Template;
            FeedbackText.Text += at1.apptemptext;
        }
    }
}
