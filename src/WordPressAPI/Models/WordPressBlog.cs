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
    public class WordPressBlog
    {
        [XmlRpcName("blogid")]
        public string Id { get; set; }

        [XmlRpcName("blogName")]
        public string Name { get; set; }

        [XmlRpcName("url")]
        public string Url { get; set; }

        [XmlRpcName("xmlrpc")]
        public string XmlRpc { get; set; }

        [XmlRpcName("isAdmin")]
        public bool IsAdmin { get; set; }
    }
}
