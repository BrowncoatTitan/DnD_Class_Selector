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

        public Classes GetClass(int id)
        {
            return _conn.QuerySingle<Classes>("SELECT * FROM classes WHERE ID = @id", new { id = id });
        }

        public void UpdateClass(Classes classes)
        {
            _conn.Execute("UPDATE classes SET Name = @name, Role = @role WHERE ID = @id",
        new { name = classes.Name, role = classes.Role, id = classes.ID });
        }
        public void InsertClass(Classes classToInsert)
        {
            _conn.Execute("INSERT INTO classes (NAME, ROLE) VALUES (@name, @role);",
                new { name = classToInsert.Name, role = classToInsert.Role});
        }

        public void DeleteClass(Classes classes)
        {
            _conn.Execute("DELETE FROM classes WHERE ID = @id;", new { id = classes.ID });
        }
    }
}
