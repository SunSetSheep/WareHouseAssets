using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WareHouseAssets.Data;
using WareHouseAssets.Models;

namespace WareHouseAssets.Pages
{
    public class CreateModel : PageModel
    {
        private readonly WareHouseAssets.Data.WareHouseAssetsContext _context;

        public CreateModel(WareHouseAssets.Data.WareHouseAssetsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Asset Asset { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Asset.Add(Asset);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
