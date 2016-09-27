using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using File.Classes;
using System.IO;
using MapWinGIS;
using AxMapWinGIS;


namespace File
{
    public partial class File: UserControl
    {
        private AxMap filemapcontrol = null;

        public const string WINDOW_TITLE = "MWLite";

        private readonly AppDispatcher _dispatcher = new AppDispatcher();
        protected string Filename { get; set; }

        private static File _file = null;

        public  AxMap FileMapControl
        {
            get
            {
                return filemapcontrol;
            }
            set
            {
                filemapcontrol = value;
            }
        }

        public File(AxMap MapControl)
        {
            filemapcontrol = MapControl;
            InitializeComponent();
            _file = this;
            InitMenus();
            RefreshUI();
            Dispatcher.InitMoveEvent();
            App.Project.ProjectChanged += (s, e) => RefreshUI();
        }

        public static File Instance
        {
            get { return _file; }
        }

        private void InitMenus()
        {
            Dispatcher.InitMenu(_toolStripLayer.Items);
        }

        internal AppDispatcher Dispatcher
        {
            get { return _dispatcher; }
        }

        public void RefreshUI()
        {
            Text = WINDOW_TITLE;
            if (!App.Project.IsEmpty)
                Text += " - " + App.Project.GetPath();
            //toolSetProjection.Enabled = App.Map.NumLayers == 0;
            //toolSetProjection.Text = App.Map.NumLayers == 0
            //    ? "Set coordinate system and projection"
            //    : "It's not allowed to change projection when layers are already added to the map.";

            //toolSearch.Enabled = true;
            //toolSearch.Text = "Find location";
            //if (App.Map.NumLayers > 0 && !App.Map.Measuring.IsUsingEllipsoid)
            //{
            //    //toolSearch.Enabled = false;
            //    //toolSearch.Text = "Unsupported projection. Search isn't allowed.";
            //}

            toolZoomIn.Checked = filemapcontrol.CursorMode == tkCursorMode.cmZoomIn;
            toolZoomOut.Checked = filemapcontrol.CursorMode == tkCursorMode.cmZoomOut;
            toolPan.Checked = filemapcontrol.CursorMode == tkCursorMode.cmPan;
            //toolSelect.Checked = filemapcontrol.CursorMode == tkCursorMode.cmSelection;
            //toolSelectByPolygon.Checked = filemapcontrol.CursorMode == tkCursorMode.cmSelectByPolygon;
            //toolIdentify.Checked = filemapcontrol.CursorMode == tkCursorMode.cmIdentify;

            bool distance = filemapcontrol.Measuring.MeasuringType == tkMeasuringType.MeasureDistance;
            //toolMeasure.Checked = filemapcontrol.CursorMode == tkCursorMode.cmMeasure && distance;
            //toolMeasureArea.Checked = filemapcontrol.CursorMode == tkCursorMode.cmMeasure && !distance;

            //if (filemapcontrol.CursorMode != tkCursorMode.cmIdentify)
            //{
            //    File.HideTooltip();
            //}

      //      bool hasShapefile = false;
       //     int layerHandle = App.Legend.SelectedLayer;
            //bool hasLayer = layerHandle != -1;
            //if (hasLayer)
            //{
            //    var sf = App.Map.get_Shapefile(layerHandle);
            //    if (sf != null)
            //    {
            //        statusSelectedCount.Text = string.Format("Shapes: {0}; selected: {1}", sf.NumShapes, sf.NumSelected);
            //        toolClearSelection.Enabled = sf.NumSelected > 0;
            //        toolZoomToSelected.Enabled = sf.NumSelected > 0;
            //        hasShapefile = true;
            //    }
            //}

            //if (!hasShapefile)
            //{
            //    statusSelectedCount.Text = "";
            //    toolClearSelection.Enabled = false;
            //    toolZoomToSelected.Enabled = false;
            //}

            //toolRemoveLayer.Enabled = hasLayer;
            //Editor.RefreshUI();

            filemapcontrol.Focus();
        }
    }
}
