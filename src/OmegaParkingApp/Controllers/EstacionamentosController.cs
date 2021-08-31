using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OmegaParkingApp.Data;
using OmegaParkingApp.ViewModels;
using OmegaParkingBusiness.Interfaces;

namespace OmegaParkingApp.Controllers
{
    public class EstacionamentosController : Controller
    {
        private readonly IEstacionamentoRepository _estacionamentoRepository;
        private readonly IMapper _mapper;

        public EstacionamentosController(IEstacionamentoRepository estacionamentoRepository, IMapper mapper)
        {
            _estacionamentoRepository = estacionamentoRepository;
            _mapper = mapper;
        }

        // GET: Estacionamentos
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<EstacionamentoViewModel>>(await _estacionamentoRepository.ObterTodos()));
        }

        /*// GET: Estacionamentos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamentoViewModel = await _context.EstacionamentoViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estacionamentoViewModel == null)
            {
                return NotFound();
            }

            return View(estacionamentoViewModel);
        }

        // GET: Estacionamentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estacionamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,TotalVagasAutomoveis,TotalVagasMotocicletas")] EstacionamentoViewModel estacionamentoViewModel)
        {
            if (ModelState.IsValid)
            {
                estacionamentoViewModel.Id = Guid.NewGuid();
                _context.Add(estacionamentoViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estacionamentoViewModel);
        }

        // GET: Estacionamentos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamentoViewModel = await _context.EstacionamentoViewModel.FindAsync(id);
            if (estacionamentoViewModel == null)
            {
                return NotFound();
            }
            return View(estacionamentoViewModel);
        }

        // POST: Estacionamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nome,TotalVagasAutomoveis,TotalVagasMotocicletas")] EstacionamentoViewModel estacionamentoViewModel)
        {
            if (id != estacionamentoViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estacionamentoViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstacionamentoViewModelExists(estacionamentoViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(estacionamentoViewModel);
        }

        // GET: Estacionamentos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamentoViewModel = await _context.EstacionamentoViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estacionamentoViewModel == null)
            {
                return NotFound();
            }

            return View(estacionamentoViewModel);
        }

        // POST: Estacionamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var estacionamentoViewModel = await _context.EstacionamentoViewModel.FindAsync(id);
            _context.EstacionamentoViewModel.Remove(estacionamentoViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstacionamentoViewModelExists(Guid id)
        {
            return _context.EstacionamentoViewModel.Any(e => e.Id == id);
        }
        */
    }
}
