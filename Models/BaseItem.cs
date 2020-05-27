using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace DataTools.Models
{
    public class BaseItem
    {
        [JsonProperty(PropertyName ="system-id")]
        public string systemID { get; set; }
        [JsonProperty(PropertyName = "update-by")]
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
