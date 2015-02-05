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
    public class WordPressAuthor
    {
        [XmlRpcName("user_id")]
        public string Id { get; set; }

        [XmlRpcName("user_login")]
        public string Login { get; set; }

        [XmlRpcName("display_name")]
        public string DisplayName { get; set; }
    }
}
