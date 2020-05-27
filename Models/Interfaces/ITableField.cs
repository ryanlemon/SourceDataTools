using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTools.Models.Interfaces
{
    interface ITableField
    {
        public string systemid { get; set; }
        public string updateby { get; set; }
        public string updatetime { get; set; }
        public string updatedate { get; set; }
        public string createdby { get; set; }
        public string createddate { get; set; }
        public string reservedstandard { get; set; }
        public string reservedcustom { get; set; }
        public float changereferencenum { get; set; }
        public string layercode { get; set; }
        public string userorgroupid { get; set; }
        public string layertype { get; set; }
        public string reservedfree { get; set; }
        public string createdtime { get; set; }
        public string reservedsupport { get; set; }
    }
}
