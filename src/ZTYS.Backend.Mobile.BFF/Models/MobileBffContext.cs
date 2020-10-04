using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZTYS.Backend.Mobile.BFF.Models
{
    public class MobileBffContext : DbContext
    {
        public MobileBffContext(DbContextOptions<DbContext> options) : base(options)
        {

        }
    }
}
