using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlRpcPortable.Converter;
using XmlRpcPortable.Models;

namespace WordPressAPI.Models
{
    [XmlRpcType(typeof(XmlRpcStruct))]
    public class WordPressEnclosure
    {
        [XmlRpcName("url")]
        public string Url { get; set; }

        [XmlRpcName("length")]
        public int Length { get; set; }

        [XmlRpcName("type")]
        public string Type { get; set; }
    }
}
