
using RIGProjeck.Class;

namespace UI
{
    public partial class Login : Form
    { 
        User user = new User();
        Main main = new Main();
        
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (user.LogIn(textBox2.Text,textBox2.Text))
            {
                main.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Register form2 = new Register();   
           form2.ShowDialog();
        }
    }
}
