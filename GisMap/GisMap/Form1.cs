using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxMapWinGIS;
using MapWinGIS;
using GisSet;
using File;

namespace GisMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitGlobalSettings();
            //Gis控件的动态加载
            AxMap axMap1 = new AxMap();
            ((System.ComponentModel.ISupportInitialize)(axMap1)).BeginInit();
            this.Controls.Add(axMap1);
            ((System.ComponentModel.ISupportInitialize)(axMap1)).EndInit();
            axMap1.Enabled = true;
            axMap1.Location = new System.Drawing.Point(0, 40);
            axMap1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom; 
            axMap1.Name = "axMap1";
            //   axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            axMap1.Size = new System.Drawing.Size(700, 700);
           // axMap1.CursorMode = tkCursorMode.cmNone;
            axMap1.Projection = tkMapProjection.PROJECTION_NONE;
            axMap1.TileProvider = tkTileProvider.ProviderNone;  //没有任何背景图

            //     axMap1.TabIndex = 2;
            
            //GisSet控件的动态加载
            //GisSetControl m_GisSetControl = new GisSetControl();
            //this.Controls.Add(m_GisSetControl);
            //m_GisSetControl.Location = new System.Drawing.Point(0, 500);
            //m_GisSetControl.Size = new System.Drawing.Size(700, 25);

            //File控件动态加载
            File.File m_FileControl = new File.File(axMap1);
            this.Controls.Add(m_FileControl);
            m_FileControl.Location = new System.Drawing.Point(0, 0);
            m_FileControl.Size = new System.Drawing.Size(700, 150);
            m_FileControl.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

         //   m_GisSetControl.MAP = axMap1;
            m_FileControl.FileMapControl = axMap1;
          
        }

        public static void InitGlobalSettings()
        {
            var gs = new GlobalSettings();
            gs.ZoomToFirstLayer = true;
            gs.OgrLayerMaxFeatureCount = 25000;
            gs.AllowLayersWithoutProjections = true;
            gs.AllowProjectionMismatch = false;
            gs.ReprojectLayersOnAdding = false;
            gs.OgrLayerForceUpdateMode = true;
            //gs.TilesThreadPoolSize = 1;
            //gs.SetHereMapsApiKey("", "");
            //gs.BingApiKey = "";
        }
    }
}
