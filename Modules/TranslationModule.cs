using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTools.Modules
{

    public class TranslationModule
    {
        public DsTranslation dsTranslation { get; set; }
    }

    public class DsTranslation
    {
        public TtTranslation[] ttTranslation { get; set; }
    }

    public class TtTranslation:BaseItem
    {
        public string sdLanguage { get; set; }
        public string sdRegion { get; set; }
        public string sdText { get; set; }
        public string sdCode { get; set; }
        public string sdAbbreviation { get; set; }
    }

}
