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
    public class DeleteModel : PageModel
    {
        private readonly WareHouseAssets.Data.WareHouseAssetsContext _context;

        public DeleteModel(WareHouseAssets.Data.WareHouseAssetsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Asset Asset { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asset = await _context.Asset.FirstOrDefaultAsync(m => m.Id == id);

            if (asset == null)
            {
                return NotFound();
            }
            else
            {
                Asset = asset;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var asset = await _context.Asset.FindAsync(id);
            if (asset != null)
            {
                Asset = asset;
                _context.Asset.Remove(Asset);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
