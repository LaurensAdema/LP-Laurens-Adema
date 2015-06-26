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
    using System.Device.Location;
    using System.Diagnostics;
    using System.Globalization;

    public partial class HOPEForm : Form
    {
        private Administration administration;

        private HOPE hope;

        public HOPEForm(Administration administrationMain, HOPE hopeLoad)
        {
            InitializeComponent();
            administration = administrationMain;
            hope = hopeLoad;

            if (hope != null)
            {
                LoadHope();
            }

            this.LoadFunctions();
            this.LoadBoats();
            this.LoadMaterials();
        }

        private void btSaveHope_Click(object sender, EventArgs e)
        {
            if (hope == null)
            {
                try
                {
                    hope = new HOPE(
                        Convert.ToDateTime(dtpDeparture.Value),
                        tbDescription.Text,
                        new GeoCoordinate(
                            Convert.ToDouble(tbLat1.Text + "." + tbLat2.Text),
                            Convert.ToDouble(tbLon2.Text + "." + tbLon2.Text)),
                        cbBoatType.SelectedItem as BoatType,
                        null,
                        null,
                        Convert.ToDateTime(dtpReturnDate.Value));
                    MessageBox.Show(administration.AddMission(hope as Mission));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invoer was fout"); // GEEN TIJD VOOR NETTERE OPLOSSING
                }
            }
            else
            {
                administration.ChangeMission(hope as Mission);
            }
        }

        private void LoadHope()
        {
            tbDescription.Text = hope.Discription;
            dtpDeparture.Value = hope.LeaveDate;
            dtpReturnDate.Value = hope.ReturnDate;

            string[] latitude = hope.Location.Latitude.ToString("000.000000", CultureInfo.InvariantCulture).Split('.');
            tbLat1.Text = latitude[0];
            tbLat2.Text = latitude[1];

            string[] longitude = hope.Location.Longitude.ToString("000.000000", CultureInfo.InvariantCulture).Split('.');
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

            cbBoatType.DisplayMember = "Type";
            cbBoatType.ValueMember = "ID";
        }

        private void LoadMaterials()
        {
            BindingSource cbMaterialsBindingSource = new BindingSource();
            cbMaterialsBindingSource.DataSource = administration.GetMaterials();

            cbMaterials.DataSource = cbMaterialsBindingSource.DataSource;

            cbMaterials.DisplayMember = "Name";
            cbMaterials.ValueMember = "ID";
        }
    }
}
