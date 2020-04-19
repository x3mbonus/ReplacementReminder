using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReplacementReminder.Data;
using ReplacementReminder.Exceptions;
using ReplacementReminder.Models;
using ReplacementReminder.Repository.Abstract;
using ReplacementReminder.Services.Abstract;

namespace ReplacementReminder.Controllers
{
    public class ReplacementItemsController : Controller
    {
        private readonly IReplacementItemsService _replacementItemsService;

        public ReplacementItemsController(
            IReplacementItemsService replacementItemsService)
        {
            _replacementItemsService = replacementItemsService;
        }

        // GET: ReplacementItems
        public ActionResult Index()
        {
            var model = _replacementItemsService.FindAll();
            return View(model);
        }

        // GET: ReplacementItems/Details/5
        public ActionResult Details(int id)
        {
            var model = _replacementItemsService.FindById(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // GET: ReplacementItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReplacementItems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReplacementItemModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (!_replacementItemsService.Create(model))
                {
                    ModelState.AddModelError("", "Cannot create item");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Something went wrong: {ex.Message}");
                return View(model);
            }
        }

        // GET: ReplacementItems/Edit/5
        public ActionResult Edit(int id)
        {            
            var model = _replacementItemsService.FindById(id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: ReplacementItems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ReplacementItemModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                if (!_replacementItemsService.Update(id, model))
                {
                    ModelState.AddModelError("", "Cannot update item");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch(ItemNotFoundException)
            {
                return NotFound(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Something went wrong: {ex.Message}");
                return View(model);
            }
        }

        // GET: ReplacementItems/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                if (!_replacementItemsService.Delete(id))
                {
                    ModelState.AddModelError("", "Cannot delete item");                    
                }
            }
            catch (ItemNotFoundException)
            {
                return NotFound(id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Something went wrong: {ex.Message}");
            }
            return RedirectToAction(nameof(Index));
        }

        //// POST: ReplacementItems/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}