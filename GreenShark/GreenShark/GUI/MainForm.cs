using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenShark.GUI
{
    public partial class MainForm : Form
    {
        private Administration administration;
        public MainForm(Administration administrationLogIn)
        {
            InitializeComponent();
            administration = administrationLogIn;

            this.LoadMissions();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.loginForm.Show();
        }

        private void btNewHOPE_Click(object sender, EventArgs e)
        {
            HOPEForm hopeForm = new HOPEForm(administration, null);
            hopeForm.Show();
        }

        private void btNewSIN_Click(object sender, EventArgs e)
        {
            SINForm sinForm = new SINForm(administration, null);
            sinForm.Show();
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcMain.SelectedTab.Text)
            {
                case "Missiebeheer":
                    this.LoadMissions();
                    break;
                case "Missieprofielen":
                    this.LoadProfiles();
                    break;
            }
        }

        private void LoadMissions()
        {
            List<Mission> missions = administration.GetMissions();

            lbxHOPE.Items.Clear();
            lbxSIN.Items.Clear();
            foreach (Mission mission in missions)
            {
                if (mission is HOPE)
                {
                    lbxHOPE.Items.Add(mission as HOPE);
                }
                else if (mission is SIN)
                {
                    lbxSIN.Items.Add(mission as SIN);
                }
            }
        }

        private void LoadProfiles()
        {
            
        }

        private void lbxSIN_SelectedValueChanged(object sender, EventArgs e)
        {
            SINForm sinForm = new SINForm(administration, lbxSIN.SelectedItem as SIN);
            sinForm.Show();
        }

        private void lbxHOPE_SelectedValueChanged(object sender, EventArgs e)
        {
            HOPEForm hopeForm = new HOPEForm(administration, lbxHOPE.SelectedItem as HOPE);
            hopeForm.Show();
        }
    }
}
