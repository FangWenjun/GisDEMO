using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.Common;


namespace File.Classes
{
    public class GisPoint:IComparable
    {
        static SQLiteConnection m_dbConnection; //数据库连接句柄
        public static long num;
        
        //温度点X坐标
        public double X
        {
            get;
            set;
        }
        //温度点Y坐标
        public double Y
        {
            get;
            set;
        }
        //温度点的温度值
        public double TEMP
        {
            get;
            set;
        }
        //温度点的id值
        public long ID
        {
            get;
            set;
        }

        public GisPoint()
        {
     
        }

        //创建一个数据库
        public static void CreateDB(string dbPath)
        {
            SQLiteConnection.CreateFile(dbPath);
        }

        //创建与数据库的连接
        public static void connectToDB(string dbPath)
        {
            m_dbConnection = new SQLiteConnection("Data Source=" + dbPath + ";Version=3;");
            m_dbConnection.Open();
        }

        //创建一个table
        public static void createTable()
        {
            string sql = "create table Point (id integer NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, x double, y double, temperature double, colour double)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        //插入一些数据
        public void fillTable()
        {
            string sql = "insert into Point (x, y, temperature, colour) values (" + X + "," + Y + "," + TEMP + ")";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        /// <summary>
        /// 从数据库中读取温度点数据至m_PointList中
        /// </summary>
        public static void readData()
        {
            int i = 0;
            string sql = "select * from point";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                GisPoint point = new GisPoint();
                point.ID = (long)reader[0];
                point.X = (double)reader[1];
                point.Y = (double)reader[2];
                point.TEMP = (double)reader[3];
                Constants.m_PointList.Add(point);
                i++;
            }
            reader.Close();
        }

        /// <summary>
        /// 读取分段节点数据
        /// </summary>
        /// <param name="m_section"></param>用于保存分段节点
        public static void readSectionData(List<section> m_section)
        {
            string sql = "select * from section";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                section sect;
                sect.id = (long)(reader[0]);
                sect.section_begin = (double)(reader[1]);
                sect.section_end = (double)(reader[2]);
                sect.color = (long)(reader[3]);
                m_section.Add(sect);
            }
            reader.Close();
        }
        /// <summary>
        /// 用于显示标签时获取温度点处的温度值
        /// </summary>
        /// <param name="a"></param>该温度点的x坐标
        /// <param name="b"></param>该温度点的y坐标
        /// <returns></returns>返回该温度点的温度
        public static string readOneData(double a, double b)
        {
            string sql = "select * ,min(abs(x-'" + a + "')+abs(y-'" + b + "')) from Point";
            // string sql = "SELECt *FROM Point ORDER BY abs(x - '"+a+"') AND abs('"+b+"' - y) LIMIT 1";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            reader.Read();
            double temp = (double)reader[3];
            string s_temp = temp.ToString();
            return s_temp;
        }
        /// <summary>
        /// 断开数据库连接
        /// </summary>
        public static void closeDB()
        {
            m_dbConnection.Close();
        }
        /// <summary>
        /// 对温度点数据进行排序
        /// </summary>
        public static void SortList()
        {
           Constants.m_PointList.Sort();

        }

        public int CompareTo(object obj)
        {
            GisPoint p = obj as GisPoint;
            if (p != null)
            {
                double pb = this.TEMP - p.TEMP;
                return (int)(pb);
            }
            return 0;
        }
    }

    /// <summary>
    /// 存放节点数据的结构体类型
    /// </summary>
    public struct section
    {
        public long id;
        public double section_begin;
        public double section_end;
        public long color;
    }
}
