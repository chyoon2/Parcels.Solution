using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcel")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcelform")]
    public ActionResult ParcelForm()
    {
      return View();
    }

    [HttpPost("/parcelform")]
    public ActionResult ParcelForm(string len, string height, string width, string weight)
    {
      int lengthInput = int.Parse(len);
      int heightInput = int.Parse(height);
      int widthInput = int.Parse(width);
      int weightInput = int.Parse(weight);   
      Parcel myParcel = new Parcel(lengthInput, heightInput, widthInput, weightInput);     
      return View("Index", myParcel);
    }
  }
}