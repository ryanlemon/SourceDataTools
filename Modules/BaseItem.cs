using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTools.Modules
{
    public class BaseItem
    {
        public string SystemID { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateTime { get; set; }
        public string UpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string ReservedStandard { get; set; }
        public string ReservedCustom { get; set; }
        public float ChangeReferencenum { get; set; }
        public string LayerCode { get; set; }
        public string UserOrGroupID { get; set; }
        public string LayerType { get; set; }
        public string ReservedFree { get; set; }
        public string CreatedTime { get; set; }
        public string ReservedSupport { get; set; }
    }
}
