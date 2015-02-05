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
    public class WordPressUser
    {
        [XmlRpcName("user_id")]
        public int Id { get; set; }

        [XmlRpcName("username")]
        public string UserName { get; set; }
        
        [XmlRpcName("first_name")]
        public string FirstName { get; set; }
        
        [XmlRpcName("last_name")]
        public string LastName { get; set; }
        
        [XmlRpcName("bio")]
        public string Bio { get; set; }
        
        [XmlRpcName("email")]
        public string Email { get; set; }
        
        [XmlRpcName("nickname")]
        public string NickName { get; set; }
        
        [XmlRpcName("nicename")]
        public string NiceName { get; set; }

        [XmlRpcName("url")]
        public string Url { get; set; }

        [XmlRpcName("display_name")]
        public string DisplayName { get; set; }

        [XmlRpcName("registered")]
        public DateTime Registered { get; set; }

        [XmlRpcName("roles")]
        public string[] Roles { get; set; }
    }
}
