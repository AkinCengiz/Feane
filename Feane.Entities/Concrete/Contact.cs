using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Entity.Concrete;
public sealed class Contact : BaseEntity
{
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}
