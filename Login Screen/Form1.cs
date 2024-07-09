namespace Login_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, password;
            user = textUser.Text;
            password = textPass.Text;

            MessageBox.Show($"Username is: {user} Password is {password}");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
