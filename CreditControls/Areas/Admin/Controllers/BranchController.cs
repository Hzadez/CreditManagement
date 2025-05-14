using CreditControls.Data;
using CreditControls.Models;
using CreditControls.Services.Interfaces;
using CreditControls.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CreditControls.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BranchController : Controller
    {
        private readonly IGenericService<BranchViewModel, Branch> _branchService;
        private readonly CreditControlsDb _context;

        public BranchController(IGenericService<BranchViewModel, Branch> branchService, CreditControlsDb context)
        {
            _branchService = branchService;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Branches.ToListAsync();
           // var branches = await _branchService.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BranchViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _branchService.CreateAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
