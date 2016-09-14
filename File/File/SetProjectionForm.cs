﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using File.Classes;
using MapWinGIS;

namespace File
{
    public partial class SetProjectionForm : Form
    {
        public SetProjectionForm()
        {
            InitializeComponent();
            cboWellKnown.Items.Add("WGS 84 (decimal degrees)");
            //cboWellKnown.Items.Add("Google Mercator");
            cboWellKnown.SelectedIndex = 0;
            RefreshControls();
            optDefinition.CheckedChanged += (s, e) => RefreshControls();
            optEmpty.CheckedChanged += (s, e) => RefreshControls();
            optWellKnown.CheckedChanged += (s, e) => RefreshControls();
        }

        private void RefreshControls()
        {
            cboWellKnown.Enabled = optWellKnown.Checked;
            txtDefinition.Enabled = optDefinition.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (App.Map.NumLayers > 0)
            {
                MessageHelper.Info("Can't change projection when there are layers on the map.");
                return;
            }

            var gp = new GeoProjection();

            if (optDefinition.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtDefinition.Text))
                {
                    MessageHelper.Info("Projection string is empty");
                    return;
                }

                if (!gp.ImportFromAutoDetect(txtDefinition.Text))
                {
                    MessageHelper.Info("Failed to identify projection");
                    return;
                }
            }

            if (optEmpty.Checked)
            {
                // do nothing it's empty all right
            }

            if (optWellKnown.Checked)
            {
                if (cboWellKnown.SelectedIndex == 0)
                    gp.SetWgs84();

                if (cboWellKnown.SelectedIndex == 1)
                    gp.SetGoogleMercator();
            }

            App.Map.GeoProjection = gp;
            App.Map.TileProvider = tkTileProvider.ProviderNone;
            App.Map.Redraw();
            DialogResult = DialogResult.OK;
        }
    }
}
