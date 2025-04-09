using FindAWord;

namespace StringManipulation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Creates a new form
            InitializeComponent();
        }

        private void addAWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sets the form for user to add a word to the sentence
            StringBox.Visible = true;
            WordBox.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            AddBTN.Visible = true;
            VerifyDateBTN.Visible = false;

        }
        private void deleteAWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sets the form for deleting a word from the sentence
            StringBox.Visible = true;
            WordBox.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            AddBTN.Visible = false;
            DeleteBTN.Visible = true;
            VerifyDateBTN.Visible = false;

        }

        private void verifyEmailIsValidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sets the form for the email verification.
            StringBox.Visible = true;
            EmailBTN.Visible = true;
            WordBox.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            AddBTN.Visible = false;
            DeleteBTN.Visible = false;
            VerifyDateBTN.Visible = false;

        }
        private void verifyDateIsValidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sets the form for the date verification
            StringBox.Visible = true;
            StringBox.PlaceholderText = "yyyy/mm/dd or dd/mm/yyyy";
            EmailBTN.Visible = false;
            WordBox.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            AddBTN.Visible = false;
            DeleteBTN.Visible = false;
            VerifyDateBTN.Visible = true;
            VerifyDateBTN.Left = 71;
        }

        private void EmailBTN_Click(object sender, EventArgs e)
        {
            //Creates a instance of String manipulation class
            StringManipulation _StrManipulation = new StringManipulation();
            Boolean Answer = false;
            //Calls the VerifyEmail method and stores value in Answer
            Answer = StringManipulation.VerifyEmail(StringBox.Text);
            //Outputs the answer in a messagebox
            if (Answer)
            {
                MessageBox.Show("You have a valid email address");
            }
            else
            {
                MessageBox.Show("You do not have a valid email address");
            }
        }
        private void AddBTN_Click(object sender, EventArgs e)
        {
            //Creates a random number to send the addWord Method
            Random _Random = new Random();
            //Calls the AddWord Method and puts the value in the Stringbox as Text
            StringBox.Text = StringManipulation.AddWord(StringBox.Text, WordBox.Text, _Random.Next(0, StringBox.TextLength - WordBox.TextLength));

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            
            //Calls the DeleteWord Method and puts the value in the Stringbox as Text
            StringBox.Text = StringManipulation.DeleteWord(StringBox.Text, WordBox.Text);

        }

        private void VerifyDateBTN_Click(object sender, EventArgs e)
        {
            Boolean Answer = false;
            //Calls the VerifyDate function
           Answer= StringManipulation.VerifyDate(StringBox.Text);
            if (Answer)
            {
                MessageBox.Show("You have a valid Date");
            }
            else
            {
                MessageBox.Show("You do not have a valid date");
            }

        }
    }
}
