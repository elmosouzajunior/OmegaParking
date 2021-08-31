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
    public class VeiculosController : Controller
    {
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IMapper _mapper;

        public VeiculosController(IVeiculoRepository veiculoRepository, IMapper mapper)
        {
            _veiculoRepository = veiculoRepository;
            _mapper = mapper;
        }

        // GET: Veiculos
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<VeiculoViewModel>>(await _veiculoRepository.ObterTodos()));
        }

        /*
        // GET: Veiculos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoViewModel = await _context.VeiculoViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculoViewModel == null)
            {
                return NotFound();
            }

            return View(veiculoViewModel);
        }

        // GET: Veiculos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Veiculos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Placa,Marca,Modelo,Cor,Observacao,TipoVeiculo")] VeiculoViewModel veiculoViewModel)
        {
            if (ModelState.IsValid)
            {
                veiculoViewModel.Id = Guid.NewGuid();
                _context.Add(veiculoViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(veiculoViewModel);
        }

        // GET: Veiculos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoViewModel = await _context.VeiculoViewModel.FindAsync(id);
            if (veiculoViewModel == null)
            {
                return NotFound();
            }
            return View(veiculoViewModel);
        }

        // POST: Veiculos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Placa,Marca,Modelo,Cor,Observacao,TipoVeiculo")] VeiculoViewModel veiculoViewModel)
        {
            if (id != veiculoViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(veiculoViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VeiculoViewModelExists(veiculoViewModel.Id))
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
            return View(veiculoViewModel);
        }

        // GET: Veiculos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var veiculoViewModel = await _context.VeiculoViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (veiculoViewModel == null)
            {
                return NotFound();
            }

            return View(veiculoViewModel);
        }

        // POST: Veiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var veiculoViewModel = await _context.VeiculoViewModel.FindAsync(id);
            _context.VeiculoViewModel.Remove(veiculoViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VeiculoViewModelExists(Guid id)
        {
            return _context.VeiculoViewModel.Any(e => e.Id == id);
        }
        */
    }
}
