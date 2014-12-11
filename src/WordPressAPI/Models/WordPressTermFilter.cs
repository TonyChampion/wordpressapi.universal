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
    public class WordPressTermFilter
    {
        public WordPressTermFilter()
        {
            Size = 10;
            Skip = 0;
            OrderBy = WordPressTermOrderBy.name;
            Order = WordPressOrder.desc;
            HideEmpty = true;
        }

        [XmlRpcName("search")]
        public string Search { get; set; }

        [XmlRpcName("hide_empty")]
        public bool HideEmpty { get; set; }

        [XmlRpcName("number")]
        public int Size { get; set; }

        [XmlRpcName("offset")]
        public int Skip { get; set; }

        [XmlRpcName("orderby")]
        public WordPressTermOrderBy OrderBy { get; set; }

        [XmlRpcName("order")]
        public WordPressOrder Order { get; set; }


    }
}
