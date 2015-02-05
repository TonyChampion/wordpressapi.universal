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
    public class WordPressOption
    {
        [XmlRpcName("desc")]
        public string Description { get; set; }

        [XmlRpcName("value")]
        public string Value { get; set; }

        [XmlRpcName("readonly")]
        public bool IsReadOnly { get; set; }
    }
}
