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
    public class RegistrosController : Controller
    {
        private readonly IRegistroRepository _registroRepository;
        private readonly IMapper _mapper;

        public RegistrosController(IRegistroRepository registroRepository, IMapper mapper)
        {
            _registroRepository = registroRepository;
            _mapper = mapper;
        }

        // GET: Registros
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<RegistroViewModel>>(await _registroRepository.ObterTodos()));
        }

        /*
        // GET: Registros/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroViewModel = await _context.RegistroViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroViewModel == null)
            {
                return NotFound();
            }

            return View(registroViewModel);
        }

        // GET: Registros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RegistroEntrada,RegistroSaida,ValorCobrado")] RegistroViewModel registroViewModel)
        {
            if (ModelState.IsValid)
            {
                registroViewModel.Id = Guid.NewGuid();
                _context.Add(registroViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroViewModel);
        }

        // GET: Registros/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroViewModel = await _context.RegistroViewModel.FindAsync(id);
            if (registroViewModel == null)
            {
                return NotFound();
            }
            return View(registroViewModel);
        }

        // POST: Registros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,RegistroEntrada,RegistroSaida,ValorCobrado")] RegistroViewModel registroViewModel)
        {
            if (id != registroViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroViewModelExists(registroViewModel.Id))
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
            return View(registroViewModel);
        }

        // GET: Registros/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registroViewModel = await _context.RegistroViewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registroViewModel == null)
            {
                return NotFound();
            }

            return View(registroViewModel);
        }

        // POST: Registros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var registroViewModel = await _context.RegistroViewModel.FindAsync(id);
            _context.RegistroViewModel.Remove(registroViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroViewModelExists(Guid id)
        {
            return _context.RegistroViewModel.Any(e => e.Id == id);
        }
        */
    }
}
