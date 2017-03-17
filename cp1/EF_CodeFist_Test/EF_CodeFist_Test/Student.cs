using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFist_Test
{
    /// <summary>
    /// Student 的摘要说明
    /// 创建人：zjx
    /// 创建时间：2017-03-17 16:15:21
    /// </summary>
    public class Student
    {
        public Student()
        {

        }

        public int StudentID { set; get; }
        public string StudentName { set; get; }

        public DateTime? BirthTime { set; get; }

        public byte[] PhotoBytes { set; get; }

        public decimal Height { set; get; }

        public float Weight { set; get; }

        public Standard Grade { set; get; }
    }
}
