using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManajemenAdminGUI;
using ManajemenAdminGUI.Forms;

namespace ManajemenPerpus.GUI
{
    public partial class LoginForm : Form
    {
        MenuAdmin MenuAdmin;
        public LoginForm()
        {
            InitializeComponent();
            this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (!string.IsNullOrWhiteSpace(username) && username == "admin" && password == "admin1234")
            {
                MessageBox.Show("Selamat, anda telah berhasil login sebagai Admin!");
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
                this.Hide();
            }
            else if(!string.IsNullOrWhiteSpace(username) && username == "user123" && password == "user1234")
            {
                MessageBox.Show("Selamat, anda telah berhasil login sebagai Anggota!");
                MenuUtama menuUtama = new MenuUtama();
                menuUtama.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal, silakan login kembali!");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
