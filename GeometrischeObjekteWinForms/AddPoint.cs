using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LutzundGrub.GeoObjekte.GeometrischeObjekteLib;
using Point = LutzundGrub.GeoObjekte.GeometrischeObjekteLib.Point;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteWinForms
{
    public partial class AddPoint : Form
    {
        public Point point { get; set; }

        public AddPoint()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            float x;
            float y;
            try
            {
                x = Convert.ToInt32(this.txb_X.Text);
                y = Convert.ToInt32(this.txb_Y.Text);
            }
            catch
            {
                MessageBox.Show("Bitte Gleitkommazahlen eingeben!!!");
                return;
            }
            point = new Point(x, y);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //optional
            Close();
        }
    }
}
