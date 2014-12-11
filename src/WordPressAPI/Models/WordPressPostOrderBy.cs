using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordPressAPI.Models
{
    public enum WordPressPostOrderBy
    {
        none,
        ID,
        author,
        title,
        date,
        modified,
        parent,
        rand,
        comment_count,
        menu_order
    }
}
