using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageWF
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'garageDataSet.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.garageDataSet.Car);
            // TODO: This line of code loads data into the 'garageDataSet1.Client' table. You can move, or remove it, as needed.
            
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
