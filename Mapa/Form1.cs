using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapa
{
    public partial class FormMapa : Form
    {
        public FormMapa()
        {
            InitializeComponent();
            gMapControl.MapProvider = GMapProviders.GoogleHybridMap;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.MinZoom = 5; // Mínimo nivel
            gMapControl.MaxZoom = 100; // Máximo nivel
            gMapControl.Zoom = 20; // Actual nivel
            gMapControl.Position = new PointLatLng(10.067178, -69.285766);
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            double latitud = Convert.ToDouble(textBoxLatitud.Text);
            double longitud = Convert.ToDouble(textBoxLongitud.Text);
            gMapControl.Position = new PointLatLng(latitud, longitud);
        }
    }
}
