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
    public class WordPressPost
    {
        [XmlRpcName("post_id")]
        public string Id { get; set; }

        [XmlRpcName("post_title")]
        public string Title { get; set; }

        [XmlRpcName("post_date")]
        public DateTime PostDate { get; set; }

        [XmlRpcName("post_date_gmt")]
        public DateTime PostDateGMT { get; set; }

        [XmlRpcName("post_modified")]
        public DateTime PostModified { get; set; }

        [XmlRpcName("post_modified_gmt")]
        public DateTime PostModifiedGMT { get; set; }

        [XmlRpcName("post_status")]
        public WordPressPostStatus Status { get; set; }

        [XmlRpcName("post_format")]
        public string Format { get; set; }

        [XmlRpcName("post_type")]
        public WordPressPostType PostType { get; set; }

        [XmlRpcName("post_name")]
        public string Name { get; set; }

        [XmlRpcName("post_author")]
        public string AuthorId { get; set; }

        [XmlRpcName("post_password")]
        public string Password { get; set; }

        [XmlRpcName("post_excerpt")]
        public string Excerpt { get; set; }

        [XmlRpcName("post_content")]
        public string Content { get; set; }

        [XmlRpcName("post_parent")]
        public string Parent { get; set; }

        [XmlRpcName("post_mime_type")]
        public string MimeType { get; set; }

        [XmlRpcName("link")]
        public string Link { get; set; }

        [XmlRpcName("guid")]
        public string Guid { get; set; }

        [XmlRpcName("menu_order")]
        public int MenuOrder { get; set; }

        [XmlRpcName("comment_status")]
        public WordPressOpenStatus CommentStatus { get; set; }

        [XmlRpcName("ping_status")]
        public WordPressOpenStatus PingStatus { get; set; }

        [XmlRpcName("sticky")]
        public bool Sticky { get; set; }

        [XmlRpcName("post_thumbnail")]
        public WordPressMediaItem PostThumbnail { get; set; }

        [XmlRpcName("terms")]
        public WordPressTerm[] Terms { get; set; }

        [XmlRpcName("custom_fields")]
        public WordPressCustomField[] CustomFields { get; set; }

        [XmlRpcName("enclosure")]
        public WordPressEnclosure Enclosure { get; set; }

    }
}
