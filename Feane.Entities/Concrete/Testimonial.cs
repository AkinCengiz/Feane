using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Entity.Concrete;
public sealed class Testimonial : BaseEntity
{
    public string Title { get; set; }
    public string FullName { get; set; }
    public string Comment { get; set; }
}
