using RTFGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTFGeneratorWinForms
{
    public partial class AddCourt : Form
    {
        public Court newCourt { get; set; }
        public AddCourt()
        {
            InitializeComponent();

            newCourt = new Court();
        }

        private void courtNameCapitalTextBox_TextChanged(object sender, EventArgs e)
        {
            newCourt.CapitalName = courtNameCapitalTextBox.Text;
        }

        private void courtNameSmallTextBox_TextChanged(object sender, EventArgs e)
        {
            newCourt.SmallName = courtNameSmallTextBox.Text;
        }

        private void cityNameSmallTextBox_TextChanged(object sender, EventArgs e)
        {
            newCourt.CityName = cityNameSmallTextBox.Text;
        }

        private void feminineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            newCourt.Gender = gender.Female;
        }

        private void masculineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            newCourt.Gender = gender.Male;
        }

        private void neutralRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            newCourt.Gender = gender.Neutral;
        }

        private void AttikaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            newCourt.Region = CourtRegion.ATTICA;
        }

        private void otherRegionadioButton_CheckedChanged(object sender, EventArgs e)
        {
            newCourt.Region = CourtRegion.OTHERREGION;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // TODO - Implement Save here.
            // for now this button closes the window, and return newCourt to caller.
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // TODO - Implement better method.
            newCourt = null;
        }

    }
}
