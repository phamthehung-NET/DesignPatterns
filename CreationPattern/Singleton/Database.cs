using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.Singleton
{
    public class Database
    {
        private static readonly Lazy<Database> DatabaseInstance = new(() => new Database());

        public static Database Instance => DatabaseInstance.Value;
        
        public string Name { get; }

        public List<Table> Tables { get; }

        private Database()
        {
            Name = "System database";
            Tables = new()
            {
                new Table("Users", "This is User Table", new() { "pk_id", "fk_Departments_departmentId" }, new() { "Id", "FirstName", "Description", "LastName", "Status", "Active", "DepartmentId" }, new(){ { "Id", "1" }, { "FirstName", "test" }, { "Description", "this is a test row" }, { "LastName", "test last name" }, { "Status", "Good" }, { "Active", "true" }, { "DepartmentId", "1" } }),
                new Table("Departments", "This is Department table", new() { "pk_id" }, new() { "Id", "Name" }, new() { { "Id", "1" }, { "Name", "test" } })
            };
        }
    }
}
