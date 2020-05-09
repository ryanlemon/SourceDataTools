using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTools.Modules.Interfaces;
namespace DataTools.Modules
{
    public class MessageModule
    {
        public DsMessages dsMessages { get; set; }
    }

    public class DsMessages
    {
        public TtMessages[] ttMessages { get; set; }
    }

    public class TtMessages:BaseItem
    {
        public string ObjLanguage { get; set; }
        public string ObjRegion { get; set; }
        public string MessageNumber { get; set; }
        public string MessageDescription { get; set; }
        public string MessageType { get; set; }
    }

}
