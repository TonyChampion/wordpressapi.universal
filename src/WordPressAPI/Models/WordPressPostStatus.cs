using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlRpcPortable.Converter;

namespace WordPressAPI.Models
{
    [XmlRpcConverterReplace("-", "_")]
    [XmlRpcConverterReplace("private", "private_post")]
    public enum WordPressPostStatus
    {
        publish,
        pending,
        draft,
        auto_draft,
        future,
        private_post,
        inherit,
        trash
    }
}
