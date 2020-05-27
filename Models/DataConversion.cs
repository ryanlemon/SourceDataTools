using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTools.Models
{
    public static class DataConversion
    {
        public static MessageList toTextList(this MessageModel message)
        {
            if(message == null)
            {
                return null;
            }
            MessageList textList = new MessageList();
            foreach(var item in message.dsMessages.ttMessages)
            {
                MessageItem textItem = new MessageItem { MsgText = item.MessageDescription, MsgCode = item.MessageNumber, MsgType = item.MessageType };
                textList.TextItems.Add(textItem);
            }
            return textList;
        }
    }
}
