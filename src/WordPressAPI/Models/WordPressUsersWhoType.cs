using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlRpcPortable.Converter;

namespace WordPressAPI.Models
{
    public enum WordPressUsersWhoType
    {
        [XmlRpcIgnore]
        all,
        authors
    }
}
