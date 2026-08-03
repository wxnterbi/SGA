using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SGA.Web.Models.Login;
using SGA.Web.Services.Login;

public class LoginController : Controller
{
    private readonly UsuarioApiService _usuarioApiService;

    public LoginController(UsuarioApiService usuarioApiService)
    {
        _usuarioApiService = usuarioApiService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(LoginViewModel model)
    {
        var usuarios = await _usuarioApiService.GetAllAsync();

        var usuario = usuarios.FirstOrDefault(x =>
            x.IdentificadorInstitucional == model.Matricula);

        if (usuario == null)
        {
            ViewBag.Error = "Matrícula incorrecta";
            return View(model);
        }

        HttpContext.Session.SetInt32("UsuarioId", usuario.Id);
        HttpContext.Session.SetString("Matricula", usuario.IdentificadorInstitucional);
        HttpContext.Session.SetString("Nombre", usuario.Nombre);

        return RedirectToAction("Index", "Home");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
}