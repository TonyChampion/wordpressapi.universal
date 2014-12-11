using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlRpcPortable.Converter;

namespace WordPressAPI.Models
{
    [XmlRpcConverterReplace("-", "_")]
    public enum WordPressPostStatus
    {
        publish,
        pending,
        draft,
        auto_draft,
        future,
        @private,
        inherit,
        trash
    }
}
