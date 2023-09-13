using System.ComponentModel;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        BindingList<string> messages = new BindingList<string>();
        public Dashboard()
        {
            InitializeComponent();

            WireUpList();
        }

        private void WireUpList()
        {
            messageListBox.DataSource = messages;
            // below for model
            //messageListBox.DisplayMember = nameof(Dashboard.Text);
        }

        private void addMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageText.Text)) 
            {
                MessageBox.Show("Please enter a message before trying to add it to the list.",
                    "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                messages.Add(messageText.Text);
                messageText.Text = "";
            }

            messageText.Focus();
        }
    }
}