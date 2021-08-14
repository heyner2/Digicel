using DigicelApps.Models;
using DigicelApps.Models.DTOs;
using DigicelApps.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigicelApps.Controllers
{
    public class CategoryController : Controller
    {
        private ICategory _cat;
        public CategoryController(ICategory cat)
        {
            _cat = cat;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult>  CategoryList()
        {
            
            return View(await _cat.Categories());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreationDto category)
        {

            if (ModelState.IsValid)
            {
                if (await _cat.Create(category))
                {
                    ViewBag.success = "La Categoria fue creada Exitosamente";
                    return View("CategoryList", await _cat.Categories());
                }
                else
                {
                    ViewBag.error = "La applicación no puedo ser creada intente nuevamente";
                    return View("Index", category);
                }
            }
            else
            {                
                return View("Index", category);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            return View(await _cat.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {

            if (ModelState.IsValid)
            {
                if (await _cat.Update(category))
                {
                    ViewBag.success = "La Categoria fue editada Exitosamente";
                    return View("CategoryList", await _cat.Categories());
                }
                else
                {
                    ViewBag.error = "La Categoria no puedo ser editada intente nuevamente";
                    return View("Index", category);
                }
            }
            else
            {
                return View("Index", category);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _cat.GetById(id));
        }


        [HttpPost]
        public async Task<IActionResult> Delete(Category category)
        {

            if (ModelState.IsValid)
            {
                if (await _cat.DeleteCategoriesAndApplications(category.Id))
                {
                    ViewBag.success = "La Categoria y sus aplicaciones fueron eliminada Exitosamente";
                    return View("CategoryList", await _cat.Categories());
                }
                else
                {
                    ViewBag.error = "La Categoria no pudo ser editada intente nuevamente";
                    return View("Index", category);
                }
            }
            else
            {
                return View("Index", category);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Top5()
        {
            return View(await _cat.GetTop5());
        }

    }
}
