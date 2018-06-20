using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpocoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 连接sqlserver 数据库
            //using (IDatabase db = new Database("sqlserver"))
            //{
            //    List<Person> users = db.Fetch<Person>("select Name, IDType from Person");

            //    foreach (var item in users)
            //    {
            //       // Console.WriteLine(item.Name+" " +item.IDType);
            //    }

            //}
            #endregion


            #region 连接oracle 数据库
            using (IDatabase db = new Database("ssss"))
            {
                try
                {
                    List<STAFF> users = db.Fetch<STAFF>("select STAFF_ID, STAFF_NAME from STAFF");

                    foreach (var item in users)
                    {
                        Console.WriteLine(item.STAFF_ID + " " + item.STAFF_NAME);
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
               

            }


            #endregion

        }
    }


    public class Person
    {
        public string Name { get; set; }
        public string IDType { get; set; }
    }

    public class STAFF
    {
        public string STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
    }
}
