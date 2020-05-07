using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTools.Services
{
    public class DataPathConfiguration
    {
        public string DataRoot { get; set; }
        public List<DataTypeMap> DataTypes { get; set; }
    }
    public class DataTypeMap
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
