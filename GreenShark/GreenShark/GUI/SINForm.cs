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
    using System.Globalization;

    public partial class SINForm : Form
    {
        private Administration administration;

        private SIN sin;

        public SINForm(Administration administrationMain, SIN sinLoad)
        {
            InitializeComponent();
            administration = administrationMain;
            sin = sinLoad;

            if (sin != null)
            {
                this.LoadSin();
            }

            this.LoadFunctions();
            this.LoadBoats();
            this.LoadMaterials();
        }

        private void LoadSin()
        {
            tbDescription.Text = sin.Discription;
            dtpDeparture.Value = sin.LeaveDate;

            string[] latitude = sin.Location.Latitude.ToString("000.000000", CultureInfo.InvariantCulture).Split('.');
            tbLat1.Text = latitude[0];
            tbLat2.Text = latitude[1];

            string[] longitude = sin.Location.Longitude.ToString("000.000000", CultureInfo.InvariantCulture).Split('.');
            tbLon1.Text = longitude[0];
            tbLon2.Text = longitude[1];
        }

        private void LoadFunctions()
        {
            BindingSource cbFunctionsBindingSource = new BindingSource();
            cbFunctionsBindingSource.DataSource = administration.GetFunctionEmployees();

            cbFunctions.DataSource = cbFunctionsBindingSource.DataSource;

            cbFunctions.DisplayMember = "Function";
            cbFunctions.ValueMember = "ID";
        }

        private void LoadBoats()
        {
            BindingSource cbBoatTypesBindingSource = new BindingSource();
            cbBoatTypesBindingSource.DataSource = administration.GetBoatTypes();

            cbBoatType.DataSource = cbBoatTypesBindingSource.DataSource;

            cbFunctions.DisplayMember = "Type";
            cbFunctions.ValueMember = "ID";
        }

        private void LoadMaterials()
        {
            BindingSource cbMaterialsBindingSource = new BindingSource();
            cbMaterialsBindingSource.DataSource = administration.GetMaterials();

            cbMaterials.DataSource = cbMaterialsBindingSource.DataSource;

            cbMaterials.DisplayMember = "Name";
            cbMaterials.ValueMember = "ID";
        }

        private void btSaveSin_Click(object sender, EventArgs e)
        {

        }
    }
}
