using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTools.Services.Interfaces
{
    public interface ITextDataService
    {
        public string[] GetList(TextType textType);
        public string GetContent(TextType textType, Region region, int index);
        
    }
    public enum TextType
    {
        Label,
        Message
    }
    public enum Region
    {
        Default,
        English
    }
}
