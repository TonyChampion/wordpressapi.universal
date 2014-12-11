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
    public class WordPressCustomField
    {
        [XmlRpcName("id")]
        public string Id { get; set; }

        [XmlRpcName("key")]
        public string Key { get; set; }

        [XmlRpcName("value")]
        public string Value { get; set; }
    }
}
