using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxMapWinGIS;
using File;
using MapWinGIS;


namespace File.Classes
{
    public static class App
    {
        private static Project _project = new Project();

        public static AxMap Map
        {
            get { return File.Instance.FileMapControl; }
        }

        public static Project Project
        {
            get { return _project; }
        }

        public static void LoadMapState(string filename)
        {
            App.Map.LockWindow(tkLockMode.lmLock);
            try
            {
                App.Map.LoadMapState(filename, null);
                InitMap();
            }
            finally
            {
                App.Map.LockWindow(tkLockMode.lmUnlock);
            }
        }

        private static void InitMap()
        {
            //axMap1.Tiles.SetProxy("127.0.0.1", 8888);
            //axMap1.Tiles.SetProxyAuthentication("temp", "1234", "");
           // App.Map.GrabProjectionFromData = true;
            App.Map.Projection = tkMapProjection.PROJECTION_NONE;
            App.Map.CursorMode = tkCursorMode.cmZoomIn;
            App.Map.SendSelectBoxFinal = true;
            App.Map.SendMouseDown = true;
            App.Map.SendMouseUp = true;
            App.Map.InertiaOnPanning = tkCustomState.csAuto;
            App.Map.ShowRedrawTime = false;
            Map.Identifier.IdentifierMode = tkIdentifierMode.imSingleLayer;
            Map.Identifier.HotTracking = true;
            Map.ShapeEditor.HighlightVertices = tkLayerSelection.lsNoLayer;
            Map.ShapeEditor.SnapBehavior = tkLayerSelection.lsNoLayer;
            App.Map.Measuring.UndoButton = tkUndoShortcut.usCtrlZ;
        }

        public static void RefreshUI()
        {
            File.Instance.RefreshUI();
        }

    }
}
