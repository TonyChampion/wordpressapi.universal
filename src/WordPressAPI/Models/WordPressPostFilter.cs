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
    public class WordPressPostFilter
    {
        public WordPressPostFilter()
        {
            Size = 10;
            Skip = 0;
            OrderBy = WordPressPostOrderBy.date;
            Order = WordPressOrder.desc;
        }

        [XmlRpcName("post_type")]
        public WordPressPostType PostType { get; set; }

        [XmlRpcName("post_status")]
        public WordPressPostStatus PostStatus { get; set; }

        [XmlRpcName("number")]
        public int Size { get; set; }

        [XmlRpcName("offset")]
        public int Skip { get; set; }

        [XmlRpcName("orderby")]
        public WordPressPostOrderBy OrderBy { get; set; }

        [XmlRpcName("order")]
        public WordPressOrder Order { get; set; }


    }
}
