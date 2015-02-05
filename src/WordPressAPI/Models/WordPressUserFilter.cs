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
    public class WordPressUserFilter
    {
        public WordPressUserFilter()
        {
            Size = 10;
            Skip = 0;
            Who = WordPressUsersWhoType.all;
            OrderBy = WordPressPostOrderBy.date;
            Order = WordPressOrder.desc;
        }

        [XmlRpcName("roles")]
        public string Role { get; set; }

        [XmlRpcName("who")]
        public WordPressUsersWhoType Who { get; set; }

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
