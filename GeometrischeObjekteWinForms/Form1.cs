using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LutzundGrub.GeoObjekte.GeometrischeObjekteLib;
using Point = LutzundGrub.GeoObjekte.GeometrischeObjekteLib.Point;

namespace LutzundGrub.GeoObjekte.GeometrischeObjekteWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_ObjektArt.Items.Add("Punkt");
            cb_ObjektArt.Items.Add("Linie");
            cb_ObjektArt.Items.Add("Kreis");
            cb_ObjektArt.Items.Add("Rechteck");
            cb_ObjektArt.SelectedIndex = 2;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            switch ((string)cb_ObjektArt.SelectedItem)
            {
                case "Punkt":
                    AddPoint addPoint = new AddPoint();
                    if (addPoint.ShowDialog() == DialogResult.OK)
                    {
                        listBox_GeoObjekte.Items.Add(addPoint.point);
                    };
                    break;
                case "Linie":
                    Line l = new Line(10, 10, 100, 100);
                    listBox_GeoObjekte.Items.Add(l);
                    break;
                case "Kreis":
                    Circle c = new Circle(50, 50, 10);
                    listBox_GeoObjekte.Items.Add(c);
                    break;
                case "Rechteck":
                    //Rectangle r = new Rectangle(1, 1, 20, 20);
                    //TODO: Rechteckklasse in Bibliothek definieren und instanziieren
                    break;
                default:
                    MessageBox.Show("Bitte Objektart auswählen!!!");
                    break;
            }
        }
    }
}
