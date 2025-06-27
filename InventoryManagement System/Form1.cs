namespace InventoryManagement_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Olaylarý baðla
            textBoxUsername.Enter += TextBoxUsername_Enter;
            textBoxUsername.Leave += TextBoxUsername_Leave;
            textBoxPassword.Enter += TextBoxPassword_Enter;
            textBoxPassword.Leave += TextBoxPassword_Leave;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Varsayýlan metinleri ayarla
            textBoxUsername.Text = "Username";
            textBoxPassword.Text = "Password";
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
                textBoxUsername.Text = "";
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
                textBoxUsername.Text = "Username";
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "Password";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Eðer kutu iþaretliyse þifre göster, deðilse gizle
            textBoxPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "Username";
            textBoxPassword.Text = "Password";
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
