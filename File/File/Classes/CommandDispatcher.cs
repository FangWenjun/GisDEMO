using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AxMapWinGIS;
using MapWinGIS;

namespace File.Classes
{
    public abstract class CommandDispatcher<T> where T : struct, IConvertible
    {
        public static int p = 0;
        public bool CommandFromName(ToolStripItem item, ref T command)
        {
            string itemName = item.Name;
            itemName = itemName.ToLower();
            var prefixes = new[] { "tool", "mnu", "ctx" };
            foreach (var prefix in prefixes)
            {
                if (itemName.StartsWith(prefix) && itemName.Length > prefix.Length)
                    itemName = itemName.Substring(prefix.Length);
            }

            var dict = Enum.GetValues(typeof(T)).Cast<T>().ToDictionary(v => v.ToString().ToLower(), v => v);
            if (dict.ContainsKey(itemName))
            {
                command = dict[itemName];
                return true;
            }

            Debug.Print("Command not found: " + itemName);

            var menu = item as ToolStripDropDownItem;
            if (menu != null && menu.DropDownItems.Count > 0)
                return false;

            if (item is ToolStripSeparator) return false;

            CommandNotFound(item);
            return false;
        }

        public abstract void Run(T command);

        protected abstract void CommandNotFound(ToolStripItem item);

        /// <summary>
        /// Sets event handlers for menu items
        /// </summary>
        public void InitMenu(ToolStripItemCollection items)
        {
            if (items == null)
                return;

            foreach (ToolStripItem item in items)
            {
                if (item.Tag == null)
                    item.Click += ItemClick;
                var menuItem = item as ToolStripDropDownItem;
                if (menuItem != null)
                {
                    InitMenu(menuItem.DropDownItems);
                }
            }
        }

        /// <summary>
        /// Runs menu commands
        /// </summary>
        private void ItemClick(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            if (item == null)
                return;
            var command = Activator.CreateInstance<T>();
            if (CommandFromName(item, ref command))
                Run(command);
        }

        public void InitMoveEvent()
        {
            App.Map.MouseMoveEvent += MapMouseMoveEvent;
        }

        void MapMouseMoveEvent(object sender, _DMapEvents_MouseMoveEvent e)
        {
            #region 单重显示

            Shapefile sf = App.Map.get_Shapefile(1);
            if (sf != null)
            {
                Labels labels = sf.Labels;
                labels.FontSize = 15;
                labels.FontBold = true;
                labels.FrameVisible = true;
                labels.FrameType = tkLabelFrameType.lfRectangle;
                labels.AutoOffset = false;
                labels.OffsetX = 40;

                LabelCategory cat = labels.AddCategory("Red");
                cat.FontColor = 255;

                double projX = 0.0;
                double projY = 0.0;
                App.Map.PixelToProj(e.x, e.y, ref projX, ref projY);
                object result = null;
                var ext = new Extents();
                ext.SetBounds(projX, projY, 0.0, projX, projY, 0.0);
                if (sf.SelectShapes(ext, 0.00005, SelectMode.INTERSECTION, ref result) && (p == 0))
                {
                    string temp = GisPoint.readOneData(projX, projY);
                    string tempx = temp + "℃";
                    if(Convert.ToDouble(temp)>=50)
                    {
                        labels.AddLabel(tempx, projX, projY, 0.0, 0); 
                    }
                    else
                    {
                        labels.AddLabel(tempx, projX, projY, 0.0, -1); 
                    }
                    
                    p = 1;

                }
                else
                {
                    sf.Labels.Clear();
                    p = 0;
                }
                App.Map.Redraw();
            }
            #endregion
        } 
    }
}
