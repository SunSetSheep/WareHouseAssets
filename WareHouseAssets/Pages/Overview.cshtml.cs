using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WareHouseAssets.Data;
using WareHouseAssets.Models;

namespace WareHouseAssets.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WareHouseAssets.Data.WareHouseAssetsContext _context;

        public IndexModel(WareHouseAssets.Data.WareHouseAssetsContext context)
        {
            _context = context;
        }

        public IList<Asset> Asset { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Asset = await _context.Asset.ToListAsync();
        }
    }
}
