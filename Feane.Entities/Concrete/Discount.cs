using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Entity.Concrete;
public sealed class Discount : BaseEntity
{
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public int Amount { get; set; }
    public DateTime ExpireDate { get; set; }
}
