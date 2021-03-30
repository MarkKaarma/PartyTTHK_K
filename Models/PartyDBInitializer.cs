using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PartyTTHK_K.Models
{
    public class PartyDBInitializer : CreateDatabaseIfNotExists<PartyContext>
    {
        protected override void Seed(PartyContext dba)
        {
            base.Seed(dba);
        }
    }
}