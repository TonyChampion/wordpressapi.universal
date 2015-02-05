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
    public class WordPressOptions
    {
        [XmlRpcName("software_name")]
        public WordPressOption SoftwareName { get; set; }

        [XmlRpcName("software_version")]
        public WordPressOption SoftwareVersion { get; set; }

        [XmlRpcName("blog_url")]
        public WordPressOption BlogUrl { get; set; }

        [XmlRpcName("home_url")]
        public WordPressOption HomeUrl { get; set; }

        [XmlRpcName("login_url")]
        public WordPressOption LoginUrl { get; set; }

        [XmlRpcName("admin_url")]
        public WordPressOption AdminUrl { get; set; }

        [XmlRpcName("image_default_link_type")]
        public WordPressOption ImageDefaultLinkType { get; set; }

        [XmlRpcName("image_default_size")]
        public WordPressOption ImageDefaultSize { get; set; }

        [XmlRpcName("image_default_align")]
        public WordPressOption ImageDefaultAlign { get; set; }

        [XmlRpcName("template")]
        public WordPressOption Template { get; set; }

        [XmlRpcName("stylesheet")]
        public WordPressOption Stylesheet { get; set; }

        [XmlRpcName("post_thumbnail")]
        public WordPressOption PostThumbnail { get; set; }

        [XmlRpcName("time_zone")]
        public WordPressOption TimeZone { get; set; }

        [XmlRpcName("blog_title")]
        public WordPressOption BlogTitle { get; set; }

        [XmlRpcName("blog_tagline")]
        public WordPressOption BlogTagline { get; set; }

        [XmlRpcName("date_format")]
        public WordPressOption DateFormat { get; set; }

        [XmlRpcName("time_format")]
        public WordPressOption TimeFormat { get; set; }

        [XmlRpcName("users_can_register")]
        public WordPressOption UsersCanRegister { get; set; }

        [XmlRpcName("thumbnail_size_w")]
        public WordPressOption ThumbnailSizeW { get; set; }

        [XmlRpcName("thumbnail_size_h")]
        public WordPressOption ThumbnailSizeH { get; set; }

        [XmlRpcName("thumbnail_crop")]
        public WordPressOption ThumbnailCrop { get; set; }

        [XmlRpcName("medium_size_w")]
        public WordPressOption MediumSizeW { get; set; }

        [XmlRpcName("medium_size_h")]
        public WordPressOption MediumSizeH { get; set; }

        [XmlRpcName("large_size_w")]
        public WordPressOption LargeSizeW { get; set; }

        [XmlRpcName("large_size_h")]
        public WordPressOption LargeSizeH { get; set; }

        [XmlRpcName("default_comment_status")]
        public WordPressOption DefaultCommentStatus { get; set; }

        [XmlRpcName("default_ping_status")]
        public WordPressOption DefaultPingStatus { get; set; }

    }
}
