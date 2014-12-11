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
    public class WordPressTerm
    {
        [XmlRpcName("term_id")]
        public string Id { get; set; }

        [XmlRpcName("name")]
        public string Name { get; set; }

        [XmlRpcName("slug")]
        public string Slug { get; set; }

        [XmlRpcName("term_group")]
        public string TermGroup { get; set; }

        [XmlRpcName("term_taxonomy_id")]
        public string TermTaxonomyId { get; set; }

        [XmlRpcName("taxonomy")]
        public string Taxonomy { get; set; }

        [XmlRpcName("description")]
        public string Description { get; set; }

        [XmlRpcName("parent")]
        public string Parent { get; set; }

        [XmlRpcName("count")]
        public int Count { get; set; }

    }
}
