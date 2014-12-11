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
    public class WordPressPostThumbnailImageMeta
    {
        [XmlRpcName("aperture")]
        public int Aperture { get; set; }

        [XmlRpcName("credit")]
        public string Credit { get; set; }

        [XmlRpcName("capture")]
        public string Capture { get; set; }

        [XmlRpcName("camera")]
        public string Camera { get; set; }

        [XmlRpcName("created_timestamp")]
        public int CreatedTimestamp { get; set; }

        [XmlRpcName("copyright")]
        public string Copyright { get; set; }

        [XmlRpcName("focal_length")]
        public int FocalLength { get; set; }

        [XmlRpcName("iso")]
        public int Iso { get; set; }

        [XmlRpcName("shutter_speed")]
        public int ShutterSpeed { get; set; }

        [XmlRpcName("title")]
        public string Title { get; set; }
    }
}
