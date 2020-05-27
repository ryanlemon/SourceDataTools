using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTools.Models.Interfaces;
namespace DataTools.Models
{
    public class MessageModel
    {
        public DsMessages dsMessages { get; set; }
    }

    public class DsMessages
    {
        public List<TtMessages> ttMessages { get; set; }
    }

    public class TtMessages:BaseItem
    {
        public string ObjLanguage { get; set; }
        public string ObjRegion { get; set; }
        public string MessageNumber { get; set; }
        public string MessageDescription { get; set; }
        public string MessageType { get; set; }
    }

    #region "Light"
    public class MessageList
    {

        public List<MessageItem> TextItems { get; set; }
    }
    public class MessageItem
    {
        public string MsgCode { get; set; }
        public string MsgText { get; set; }
        public string MsgType { get; set; }
    }
    #endregion "Light"
}
