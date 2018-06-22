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
            //using (IDatabase db = new Database("ssss"))
            //{
            //    try
            //    {
            //        List<STAFF> users = db.Fetch<STAFF>("select STAFF_ID, STAFF_NAME from STAFF");

            //        foreach (var item in users)
            //        {
            //            Console.WriteLine(item.STAFF_ID + " " + item.STAFF_NAME);
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        throw;
            //    }


            //}


            #endregion

            #region 通过id查询
            //IDatabase db = new Database("ssss");

            //STAFF staff = db.SingleById<STAFF>(7); //这里指主键，我们没有指定主键，所以它不知道

            //Console.WriteLine(staff.STAFF_NAME);

            #endregion

            #region via Sql (通过sql语句查找)

            //IDatabase db = new Database("ssss");
            //STAFF staff = db.Single<STAFF>("WHERE STAFF_ID =@0", 7);
            //Console.WriteLine(staff.STAFF_NAME); //OK

            #endregion

            #region 插入数据
            //IDatabase db2 = new Database("estate");
            //STAFFPERMISSON st = new STAFFPERMISSON();
            //st.STAFFID = "66";
            //st.STAFFNAME = "蜡笔小新";
            //st.ISPROMISE = 1;



            //db2.Insert<STAFFPERMISSON>("STAFFPERMISSON", "STAFFID",false, st);


            #endregion

            #region 读取数据 与更新数据
            //IDatabase db = new Database("ssss");
            //var staff = db.SingleById<STAFF>(7);
            //staff.STAFF_NAME = "海绵宝宝";
            //db.Update(staff);
            //Console.WriteLine(staff.STAFF_ID+" : "+staff.STAFF_NAME);



            #endregion


            #region 删除数据
            IDatabase db = new Database("estate");

            var staffpermission = db.SingleById<STAFFPERMISSON>(66);
            db.Delete(staffpermission);



            #endregion

            Console.ReadKey();

        }
    }


    public class Person
    {
        public string Name { get; set; }
        public string IDType { get; set; }
    }


    //Mapping 关系
    [TableName("STAFF")]
    [PrimaryKey("STAFF_ID")]  //加了之后，就可以通过ID来查询了
    public class STAFF
    {
        [Column("STAFF_ID")]
        public int STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
    }

    [TableName("STAFFPERMISSON")]
    [PrimaryKey("STAFFID")]
    public class STAFFPERMISSON
    {
        //[Column("STAFFID")]
        public string STAFFID { get; set; }
        [Column("STAFFNAME")]
        public string STAFFNAME { get; set; }
        [Column("ISPROMISE")]
        public int ISPROMISE { get; set; }

        //public STAFFPERMISSON(string _staffid, string _staffname, int _ispromise)
        //{
        //    this.STAFFID = _staffid;
        //    this.STAFFNAME = _staffname;
        //    this.ISPROMISE = _ispromise;
        //}
    }
}
