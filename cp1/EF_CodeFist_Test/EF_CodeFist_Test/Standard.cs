using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFist_Test
{
    /// <summary>
    /// Standard 的摘要说明
    /// 创建人：zjx
    /// 创建时间：2017-03-17 16:17:33
    /// </summary>
    public class Standard
    {
        public Standard()
        {

        }

        public int StandardId { set; get; }
        public string StandardName { set; get; }

        public ICollection<Student> Students { set; get; } 
    }
}
