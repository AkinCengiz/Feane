using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Entity.Concrete;
public sealed class SocialAccount : BaseEntity
{
    //SocialAccount	==> Platform, WebUrl, UserName, Icon

    public string Platform { get; set; }
    public string WebUrl { get; set; }
    public string UserName { get; set; }
    public string Icon { get; set; }
}
