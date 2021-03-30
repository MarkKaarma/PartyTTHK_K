using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PartyTTHK_K.Models
{
    public class GuestContext: DbContext
    {
        public DbSet<Guest> Guests { get; set; }
    }
}