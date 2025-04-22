using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationPattern.Singleton
{
    public class Table
    {
        public string Name { get; }

        public string Description { get; }

        public List<string> Constraints { get; }

        public List<string> ColumnNames { get; }

        public Dictionary<string, string> RowData { get; }

        public Table(string name, string des, List<string> constraints, List<string> columns, Dictionary<string, string> data)
        {
            Name = name;
            Description = des;
            Constraints = constraints;
            ColumnNames = columns;
            RowData = data;
        }

        public string GetDataByColumn(string column)
        {
            if (RowData.TryGetValue(column, out var result))
            {
                return result;
            }
            return string.Empty;
        }
    }
}
