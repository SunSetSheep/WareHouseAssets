using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WareHouseAssets.Models;

namespace WareHouseAssets.Data
{
    public class WareHouseAssetsContext : DbContext
    {
        public WareHouseAssetsContext (DbContextOptions<WareHouseAssetsContext> options)
            : base(options)
        {
        }

        public DbSet<WareHouseAssets.Models.Asset> Asset { get; set; } = default!;
    }
}
