using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HotelBookingController : Controller
    {
        public IActionResult HotelBooking()
        {
            HotelViewModel newGuest = new HotelViewModel() 
            { 
                Id = 1, GuestName = "Fabio", 
                DateStart = new DateTime(2023, 02, 16, 11, 15, 33), 
                DateEnd = new DateTime(2023, 02, 24, 17, 32, 22) };
            return View(newGuest);
        }

    }
}
