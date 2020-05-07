using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using DataTools.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.CodeAnalysis;

namespace DataTools.Services
{
    public class TextDataService : ITextDataService
    {
        private readonly ILogger<TextDataService> _logger;
        private readonly IOptions<DataPathConfiguration> _dataPath;
        public TextDataService(ILogger<TextDataService> logger,
                        IOptions<DataPathConfiguration> options)
        {
            _logger = logger;
            _dataPath = options;

        }
        public string GetContent(TextType textType, Region region = Region.Default, int index = 0)
        {
            switch (textType)
            {
                case TextType.Label:

                    break;
                case TextType.Message:

                    break;
                default:
                    _logger.LogError("Invalid TextType", this);
                    break;
            }
            return "";
        }

        public string[] GetList(TextType textType)
        {
            string fullPath = Path.Combine(FilePath(textType),"Default.json");

            return null;
        }
        private string FilePath(TextType textType)
        {
            DataTypeItem typeItem = _dataPath.Value.DataTypes.Find(item =>
            {
                if (item.Type.ToLower() == textType.ToString().ToLower())
                    return true;
                return false;
            });
            return Path.Combine(_dataPath.Value.DataRoot, typeItem.Value);
        }
    }
}
