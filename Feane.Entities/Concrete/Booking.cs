using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feane.Entity.Concrete;
public sealed class Booking : BaseEntity
{
    //Booking 	==> FullName, Phone, Email, GuestCount, BookingDate
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public byte GuestCount { get; set; }
    public DateTime BookingDate { get; set; }
    public bool IsConfirm { get; set; } = false;
}
