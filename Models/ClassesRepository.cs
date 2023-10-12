using System.Data;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace D_D_Class_Selector.Models
{
    public class ClassesRepository : IClassesRepository
    {
        private readonly IDbConnection _conn;
        public ClassesRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Classes> GetAllClasses()
        {
            return _conn.Query<Classes>("SELECT * FROM classes"); 
        }
        public Classes GetClasses(int id)
        {
            return _conn.QuerySingle<Classes>("SELECT * FROM classes WHERE ClassID = @id", new { id = id });
        }
        
    }
}
