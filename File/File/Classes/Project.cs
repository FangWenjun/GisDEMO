using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Classes
{
    public class Project:ProjectBase
    {
        public bool TryClose()
        {
            //if (!Editor.StopAllEditing())
            //    return false;
            if (TryCloseProject())
            {
                App.Map.ShapeEditor.Clear();
                //App.Legend.Groups.Clear();
                App.Map.RemoveAllLayers();
                //App.Legend.Layers.Clear();
                App.Map.SetDefaultExtents();
                return true;
            }
            return false;
        }
      
        public void Load(string filename)
        {
            LoadProject(filename);
        }

        public void SaveAs()
        {
            SaveProjectAs();
        }

        public bool Save()
        {
            return SaveCurrentProject();
        }

        public bool IsEmpty
        {
            get { return Filename.Length == 0; }
        }

        public string GetPath()
        {
            return Filename;
        }

        public ProjectState GetState()
        {
            return State;
        }
    }
}
