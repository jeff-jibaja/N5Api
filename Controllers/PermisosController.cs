using Microsoft.AspNetCore.Mvc;
using N5PermisosUsuario.Domain.Dto;
using N5PermisosUsuario.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N5PermisosUsuario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermisosController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;


        public PermisosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

       
        [HttpGet(nameof(ObtenerPermiso))]
        public async Task<IActionResult> ObtenerPermiso() => Ok(await _unitOfWork.tipoPermiso.GetAll());


        [HttpPost(nameof(SolicitarPermisos))]
        public async Task<IActionResult> SolicitarPermisos()
        {
            return Ok(await _unitOfWork.permisos.GetAll());
        }

        [HttpPut(nameof(ModificarPermiso))]
        public async Task<IActionResult> ModificarPermiso(UsuarioPermisoDTO permiso)
        {           
            return Ok(await _unitOfWork.permisos.Update(permiso));
        }
    }
}
