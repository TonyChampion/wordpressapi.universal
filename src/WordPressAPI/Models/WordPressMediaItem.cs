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
    public class WordPressMediaItem
    {
        [XmlRpcName("attachment_id")]
        public string Id { get; set; }

        [XmlRpcName("date_created_gmt")]
        public DateTime DateCreatedGMT { get; set; }

        [XmlRpcName("parent")]
        public int Parent { get; set; }

        [XmlRpcName("link")]
        public string Link { get; set; }
    
        [XmlRpcName("title")]
        public string Title { get; set; }

        [XmlRpcName("caption")]
        public string Caption { get; set; }

        [XmlRpcName("description")]
        public string Description { get; set; }

        [XmlRpcName("metadata")]
        public WordPressMediaItemMetadata Metadata { get; set; }

        [XmlRpcName("image_meta")]
        public WordPressPostThumbnailImageMeta ImageMeta { get; set; }

        [XmlRpcName("thumbnail")]
        public string Thumbnail { get; set; }
    }
}
