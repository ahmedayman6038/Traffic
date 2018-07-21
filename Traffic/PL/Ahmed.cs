using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic.PL
{
    public partial class Ahmed : Form
    {
        public Ahmed()
        {
            InitializeComponent();
        }

        private void Ahmed_Load(object sender, EventArgs e)
        {

            gMapControl1.DragButton = MouseButtons.Left;

            //use google provider
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            //get tiles from server only
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;
            //not use proxy
            GMapProvider.WebProxy = null;
            //center map on moscow
            gMapControl1.Position = new PointLatLng(37.31917, -122.04511);

            //zoom min/max; default both = 2
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;
            //set zoom
            gMapControl1.Zoom = 15;
            var point  = new PointLatLng(37.31917, -122.04511);
            GMapMarker mapMarker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
            var point2 = new PointLatLng(37.36764, -122.16986);
            GMapMarker mapMarker2 = new GMarkerGoogle(point2, GMarkerGoogleType.red_dot);
            var point3 = new PointLatLng(37.37138, -122.14286);
            GMapMarker mapMarker3 = new GMarkerGoogle(point3, GMarkerGoogleType.red_dot);
            GMapOverlay mapOverlay = new  GMapOverlay("marker");
            mapOverlay.Markers.Add(mapMarker);
            mapOverlay.Markers.Add(mapMarker2);

            mapOverlay.Markers.Add(mapMarker3);

            gMapControl1.Overlays.Add(mapOverlay);
        }
    }
}
