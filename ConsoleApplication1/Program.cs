using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace ConsoleApplication1
{

    class StaticVar
    {
        public static int num;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
    }

    class Program
    {
        /*public static void PrintPersons()
        {
            
            //准备数据
            DataTable dt = new DataTable();
            DataRow datarow = null;

            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("UserName", typeof(string)));
            dt.Columns.Add(new DataColumn("DeptNo", typeof(string)));
            dt.Columns.Add(new DataColumn("DeptName", typeof(string)));
            
            for (int i = 10; i <= 18; i++)
            {
                datarow = dt.NewRow();
                datarow["ID"] = i;
                datarow["UserName"] = "姓名" + i.ToString();

                if (i < 15)
                {
                    datarow["DeptNo"] = "0001";
                    datarow["DeptName"] = "人事部";
                }
                else
                {
                    datarow["DeptNo"] = "0002";
                    datarow["DeptName"] = "生产部";
                }
                dt.Rows.Add(datarow);
            }

            Console.WriteLine("分组前：");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(string.Format("{0} {1} {2} {3} ", row.ItemArray));
            }
            Console.WriteLine("");

            Console.WriteLine("分组后：");

            //Linq分组查询，并按分组显示人员明细
            var query = from g in dt.AsEnumerable()
                        group g by new { t1 = g.Field<string>("DeptNo"), t2 = g.Field<string>("DeptName") } into Group
                        select new { DeptNo = Group.Key.t1, DeptName = Group.Key.t2, StallInfo = Group, domainCount = Group.Count() };
            
            foreach (var userInfo in query)
            {
                List<DataRow> dataRows = userInfo.StallInfo.ToList();
                Console.WriteLine(string.Format("{0}({1}){2}人员名单: ", userInfo.DeptName, userInfo.DeptNo, userInfo.domainCount));
                foreach (DataRow dr in dataRows)
                {
                    Console.WriteLine(string.Format("{0} {1} ", dr.ItemArray));
                }
            }
            Console.ReadLine();
        }*/
[AttributeUsage(AttributeTargets.Class)]
        class Line
        {
            private double length;   // 线条的长度
            public Line()
            {
                Console.WriteLine("对象已创建");
            }

            public void setLength(double len)
            {
                length = len;
            }
            public double getLength()
            {
                return length;
            }
        }


        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sta };

        static void Main(string[] args)
        {
            //    PrintPersons();
            //Console.ReadKey();

            FileStream F = new FileStream("sample.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            taticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());
            Console.ReadKey();

            Line line = new Line();
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
            Console.ReadKey();

            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            Console.ReadKey();

            

            int x = (60 & 13);

            string s1 = "1";
            string[] s2 = { "a", "b", "c" };
            Console.WriteLine(string.Join("...", s2));
            Console.ReadKey();

            double? num1 = 1.2;
            double? num2 = 3.14157;
            double num4 = 1.23;
            double num3;
            num3 = num1 ?? num4;
            Console.WriteLine("num3 的值： {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine("num3 的值： {0}", num3);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
