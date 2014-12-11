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
    public class WordPressTaxonomy
    {
        [XmlRpcName("name")]
        public string Name { get; set; }
        
        [XmlRpcName("label")]
        public string Label { get; set; }

        [XmlRpcName("hierarchical")]
        public bool Hierarchical { get; set; }
        
        [XmlRpcName("public")]
        public bool Public { get; set; }
        
        [XmlRpcName("show_ui")]
        public bool ShowUI { get; set; }

        [XmlRpcName("_builtin")]
        public bool BuiltIn { get; set; }

    }
}
