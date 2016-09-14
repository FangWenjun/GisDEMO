using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File.Classes
{
    public static class FileHelper
    {
        private static string GetFilter(FileType fileType)
        {
            switch (fileType)
            {
                case FileType.Project:
                    return "MWLite project state (*.mwxml)|*.mwxml";
                default:
                    return "All files|*.*";
            }
        }

        public static bool ShowOpenDialog( FileType fileType, out string filename)
        {
            filename = "";
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = GetFilter(fileType);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    filename = dlg.FileName;
                    return true;
                }
            }
            return false;
        }

        public static bool ShowSaveDialog(FileType fileType, ref string filename)
        {
            bool result = false;
            using (var dlg = new SaveFileDialog { Filter = GetFilter(fileType) })
            {
                if (!string.IsNullOrWhiteSpace(filename))
                {
                    dlg.InitialDirectory = Path.GetDirectoryName(filename);
                    dlg.FileName = Path.GetFileName(filename);
                }

                result = dlg.ShowDialog() == DialogResult.OK;
                filename = dlg.FileName;
            }
            return result;
        }
    }
    
}
