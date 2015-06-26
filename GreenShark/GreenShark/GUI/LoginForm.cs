using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenShark
{
    using GreenShark.GUI;

    public partial class LoginForm : Form
    {
        private LogIn logIn = new LogIn();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administration administration = new Administration(null);
            MainForm form = new MainForm(administration);
            form.Show();
        }
    }
}
