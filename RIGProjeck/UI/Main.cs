using Microsoft.VisualBasic.ApplicationServices;
using RIGProjeck.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Main : Form
    {
        Nepremičnina Nepremicnina  = new Nepremičnina();
        RIGProjeck.Class.User user = new RIGProjeck.Class.User();
        NepremicninaDB nepremicninadb = new NepremicninaDB();
        public string username { get; set; }
        public Main()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Main main = new Main();
            main.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //username = listView1.SelectedItems[0].ToString();
            username = listView1.SelectedItems[0].ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var user in nepremicninadb.Users)
            {
                // Check if the item already exists in the ListView
                bool itemExists = listView1.Items.Cast<ListViewItem>().Any(item => item.Text == user.username);

                // If the item doesn't exist, add it to the ListView
                if (!itemExists)
                {
                    listView1.Items.Add(user.username);
                }
            }

            foreach (var user in nepremicninadb.Users)
            {
                // Check if the item already exists in the ListView
                bool itemExists = listView2.Items.Cast<ListViewItem>().Any(item => item.Text == user.username);

                // If the item doesn't exist, add it to the ListView
                if (!itemExists && user.verified == true)
                {
                    listView2.Items.Add(user.username);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user.VerifyUser(username);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nepremicnina.LoadUserAds((int)numericUpDown1.Value);
            foreach (var item in Nepremicnina.UporabnikoveObjave)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
