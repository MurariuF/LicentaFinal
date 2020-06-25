using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientNotifications;
using Licenta.Data;
using Licenta.Models;
using Licenta.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using static ClientNotifications.Helpers.NotificationHelper;

namespace Licenta.Controllers
{
    public class DetaliiController : Controller
    {
        private IDetaliiRepository _detaliiRepository;
        private UserManager<ApplicationUser> _userManager;

        public DetaliiController(UserManager<ApplicationUser> userManager,
                                    IDetaliiRepository detaliiRepository)
        {
            _detaliiRepository = detaliiRepository;
            _userManager = userManager;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId =  _userManager.GetUserId(HttpContext.User);
            var detaliis = await _detaliiRepository.GetDetaliiByUserId(userId);
            return View(detaliis);
        }


        [HttpGet]
        [Authorize]
        public IActionResult Create()
        {
            ViewBag.IsEditMode = "false";
            var detalii = new Detalii();
            return View(detalii);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(Detalii detalii, string IsEditMode)
        {

            try
            {
                if (IsEditMode.Equals("false"))
                {
                    var userId = _userManager.GetUserId(this.HttpContext.User);
                    detalii.UserId = userId;
                    await _detaliiRepository.Create(detalii);

                }
                else
                {
                    var userId = _userManager.GetUserId(this.HttpContext.User);
                    detalii.UserId = userId;
                    await _detaliiRepository.Edit(detalii);
                }
                   
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                return Content("Nu s-a putut crea sau edita inregistrarea!");
            }

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var loggedInUserId = _userManager.GetUserId(HttpContext.User);

            ViewBag.IsEditMode = "true";
            var detalii = await _detaliiRepository.GetSingleDetalii(Id);
            if (!detalii.UserId.Equals(loggedInUserId))
            {
                return Content("Nu sunteti autorizat!");
            }
            return View("Create", detalii);
        }

        public async Task<IActionResult> Delete(int id)
        {
         
                var detalii = await _detaliiRepository.GetSingleDetalii(id);
                await _detaliiRepository.Delete(detalii);
                return RedirectToAction(nameof(Index));

        }

    }
}
