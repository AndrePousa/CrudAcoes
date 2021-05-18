﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TarefaMvc.Data;
using TarefaMvc.Models;

namespace TarefaMvc.Controllers
{
    public class AcoesController : Controller
    {
        private readonly TarefaMvcContext _context;
        private readonly StringComparison stringComparison;

        public AcoesController(TarefaMvcContext context)
        {
            _context = context;
        }

        // GET: Acoes
        public async Task<IActionResult> Index(DateTime? minDate, DateTime? maxDate, string buscar, string stringComparison)
        {
            var result = from obj in _context.Acoes select obj;
           
            if (buscar != null && buscar != "")
            {
                // result = result.Where(x => x.Acao == buscar);
                result = result.Where(x => x.Acao.Contains(buscar));

                ViewData["buscar"] = buscar;
            }

            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data_hora >= minDate.Value);

                ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            }

            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data_hora.Date <= maxDate.Value.Date);

                ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            }

            //ação para buscar 
            return View(
                await result             
                .OrderByDescending(acao => acao.Data_hora)
                .ToListAsync()
            ) ;
        }

        // GET: Acoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acoes = await _context.Acoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acoes == null)
            {
                return NotFound();
            }

            return View(acoes);
        }

        // GET: Acoes/Create
        public IActionResult Create()
        {
            return View();
        } 
       
        // GET: Acoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acoes = await _context.Acoes.FindAsync(id);
            if (acoes == null)
            {
                return NotFound();
            }
            return View(acoes);
        }

        // POST: Acoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("Id,Acao,Quantidade,Preco,Tipo,Data_hora,Observacao")] Acoes acoes)
        {
            if (id != acoes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcoesExists(acoes.Id))
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
            return View(acoes);
        }

        // GET: Acoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var acoes = await _context.Acoes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acoes == null)
            {
                return NotFound();
            }

            return View(acoes);
        }

        // POST: Acoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var acoes = await _context.Acoes.FindAsync(id);
            _context.Acoes.Remove(acoes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcoesExists(int id)
        {
            return _context.Acoes.Any(e => e.Id == id);
        }
    }
}
