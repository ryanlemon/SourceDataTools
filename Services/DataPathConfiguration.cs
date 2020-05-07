using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTools.Services
{
    public class DataPathConfiguration
    {
        public string DataRoot { get; set; }
        public List<DataTypeItem> DataTypes { get; set; }
    }
    public class DataTypeItem
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
