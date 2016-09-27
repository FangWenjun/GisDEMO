using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapWinGIS;
using AxMapWinGIS;
using File;

namespace File.Classes
{
    internal static class LayerHelper
    {
        private static int Add(AxMap map, object layer, bool Visible)
        {
            if (layer == null) return -1;
            if (map == null)
                throw new System.Exception("MapWinGIS.Map Object not yet set. Set Map Property before adding layers");

            map.LockWindow(MapWinGIS.tkLockMode.lmLock);
            int MapLayerHandle = map.AddLayer(layer, Visible);

            if (MapLayerHandle < 0)
            {
                map.LockWindow(MapWinGIS.tkLockMode.lmUnlock);
                return MapLayerHandle;
            }

            MapWinGIS.Shapefile sf = (layer as MapWinGIS.Shapefile);

            map.LockWindow(MapWinGIS.tkLockMode.lmUnlock);

            // FireLayerAdded(MapLayerHandle);

            return MapLayerHandle;
        }

        public static void AddLayer(LayerType layerType)
        {
            var map = App.Map;

            var dlg = new OpenFileDialog { Filter = map.GetLayerFilter(layerType), Multiselect = true };

            if (dlg.ShowDialog() != DialogResult.OK) return;

        //    var legend = App.Legend;

        //    legend.Lock();
            map.LockWindow(tkLockMode.lmLock);

            string layerName = "";
            try
            {
                var fm = new FileManager();
                foreach (var name in dlg.FileNames.ToList())
                {
                    layerName = name;
                    var layer = fm.Open(name);
                    if (layer == null)
                    {
                        string msg = string.Format("Failed to open datasource: {0} \n {1}", name, fm.ErrorMsg[fm.LastErrorCode]);
                        MessageHelper.Warn(msg);
                    }
                    else if (layer is OgrDatasource)
                    {
                        var ds = layer as OgrDatasource;
                        for (int i = 0; i < ds.LayerCount; i++)
                        {
                            var l = ds.GetLayer(i, false);
                            //AddLayer(l);
                        }
                        map.ZoomToMaxExtents();
                    }
                    else
                    {
                        Add(map,layer,true);
                    }
                }
            }
            catch
            {
                MessageHelper.Warn("There was a problem opening layer: " + layerName);
            }
            finally
            {
           //     legend.Unlock();
                map.LockWindow(tkLockMode.lmUnlock);
            }
        }

        public static void ZoomToLayer()
        {
          //  int handle = App.Legend.SelectedLayer;
           // App.Map.ZoomToLayer(handle);
        }

        public static void ZoomToSelected()
        {
         //   int handle = App.Legend.SelectedLayer;
          //  App.Map.ZoomToSelected(handle);
        }

        //public static void ClearSelection()
        //{
        //    int handle = App.Legend.SelectedLayer;
        //    var sf = App.Map.get_Shapefile(handle);
        //    if (sf != null)
        //    {
        //        sf.SelectNone();
        //        MainForm.Instance.RefreshUI();
        //        App.Map.Redraw();
        //    }
        //}

        //public static void OpenOgrLayer()
        //{
        //    using (var form = new OgrLayerForm())
        //    {
        //        form.LayerAdded += (s, e) =>
        //        {
        //            if (e.Layer == null) return;
        //            AddLayer(e.Layer);
        //            App.Map.Refresh();
        //            App.Legend.Refresh();
        //        };
        //        form.ShowDialog(MainForm.Instance);
        //    }
        //}

        public static void CreatePointShapefile(AxMap Map, List<GisPoint>[] ListData, int num)
        {
            var sf = new Shapefile(); //创建一个新的shp文件
            bool result = sf.CreateNewWithShapeID("", ShpfileType.SHP_MULTIPOINT);  //初始化shp文件
            for (int j = 0; j < num - 1; j++)
            {
                Shape shp = new Shape(); //创建shp图层
                shp.Create(ShpfileType.SHP_MULTIPOINT);
                for (int i = 0; i < ListData[j].Count; i++)
                {
                    var pnt = new Point();
                    pnt.x = ListData[j][i].X;
                    pnt.y = ListData[j][i].Y;
                    pnt.Key = "fang";
                    int index = 0;
                    shp.InsertPoint(pnt, ref index);
                }
                sf.EditAddShape(shp);
                if (j == 0)
                {
                    var utils = new Utils();
                    ShapefileCategory ct = sf.Categories.Add("0");
                    ct.DrawingOptions.FillType = tkFillType.ftGradient;
                    ct.DrawingOptions.FillColor = utils.ColorByName(tkMapColor.Green);
                    sf.set_ShapeCategory(0, 0);
                }
                else if (j == 1)
                {
                    var utils = new Utils();
                    ShapefileCategory ct = sf.Categories.Add("1");
                    ct.DrawingOptions.FillType = tkFillType.ftStandard;
                    ct.DrawingOptions.FillColor = utils.ColorByName(tkMapColor.Blue);
                    sf.set_ShapeCategory(1, 1);
                }
                else if (j == 2)
                {
                    var utils = new Utils();
                    ShapefileCategory ct = sf.Categories.Add("2");
                    ct.DrawingOptions.FillType = tkFillType.ftStandard;
                    ct.DrawingOptions.FillColor = utils.ColorByName(tkMapColor.Yellow);
                    sf.set_ShapeCategory(2, 2);
                }
                else
                {
                    var utils = new Utils();
                    ShapefileCategory ct = sf.Categories.Add("3");
                    ct.DrawingOptions.FillType = tkFillType.ftStandard;
                    ct.DrawingOptions.FillColor = utils.ColorByName(tkMapColor.Red);
                    sf.set_ShapeCategory(3, 3);
                }

            }
            Map.AddLayer(sf, true);
            Map.SendMouseMove = true;
        }
    }
}
