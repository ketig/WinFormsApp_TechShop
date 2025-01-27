namespace WinFormsApp_TechShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_signIn_Click(object sender, EventArgs e)
        {
            string id = User.SignIn(textBox_email.Text, textBox_password.Text);
            label_id.Text = id;
        }
    }
}
