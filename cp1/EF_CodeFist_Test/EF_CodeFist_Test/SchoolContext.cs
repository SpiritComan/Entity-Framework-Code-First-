using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFist_Test
{
    /// <summary>
    /// SchoolContext 的摘要说明
    /// 创建人：zjx
    /// 创建时间：2017-03-17 16:19:24
    /// </summary>
    public class SchoolContext:DbContext
    {
        public SchoolContext()
            : base("name = NorthwindConnectionString")
        {

        }

        public DbSet<Student> Students { set; get; }
        public DbSet<Standard> Standards { set; get; }
    }
}
