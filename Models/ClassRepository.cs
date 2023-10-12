using System.Data;
using System.Collections.Generic;
using System.Linq;
using Dapper;

namespace D_D_Class_Selector.Models
{
    public class ClassRepository : IClassRepository
    {
        private readonly IDbConnection _conn;
        public ClassRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Classes> GetAllClasses()
        {
            return _conn.Query<Classes>("SELECT * FROM classes"); 
        }
    }
}
