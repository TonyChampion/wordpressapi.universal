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
    public class WordPressMediaItemMetadata
    {
        [XmlRpcName("width")]
        public int Width { get; set; }

        [XmlRpcName("height")]
        public int Height { get; set; }

        [XmlRpcName("file")]
        public string File { get; set; }

        // Not implemented
        //[XmlRpcName("sizes")]
        //public string Sizes { get; set; }
    }
}
