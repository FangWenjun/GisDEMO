using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File.Classes
{
    public static class Constants
    {
        internal static List<GisPoint> m_PointList = new List<GisPoint>(); //用于保存数据库中温度点数据

        internal static string dbname = "Data Source=" + new DirectoryInfo("../../../../../").FullName + "File\\File\\data\\data.db";//sqlite数据库路径

        //internal static 
    }
}
