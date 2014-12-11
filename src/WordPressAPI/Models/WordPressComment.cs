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
    public class WordPressComment
    {
        [XmlRpcName("comment_id")]
        public string Id { get; set; }

        [XmlRpcName("parent")]
        public string Parent { get; set; }

        [XmlRpcName("user_id")]
        public string UserId { get; set; }

        [XmlRpcName("date_created_gmt")]
        public DateTime DateCreated { get; set; }

        [XmlRpcName("status")]
        public string Status { get; set; }

        [XmlRpcName("content")]
        public string Content { get; set; }

        [XmlRpcName("link")]
        public string Link { get; set; }

        [XmlRpcName("post_id")]
        public string PostId { get; set; }

        [XmlRpcName("post_title")]
        public string PostTitle { get; set; }

        [XmlRpcName("author")]
        public string Author { get; set; }

        [XmlRpcName("author_url")]
        public string AuthorUrl { get; set; }

        [XmlRpcName("author_email")]
        public string AuthorEmail { get; set; }

        [XmlRpcName("author_ip")]
        public string AuthorIP { get; set; }

        [XmlRpcName("type")]
        public string Type { get; set; }

    }
}
