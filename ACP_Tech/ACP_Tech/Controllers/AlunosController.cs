using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ACP_Tech.Data;
using ACP_Tech.Models;
using ACP_Tech.Models.ViewModels;
using ACP_Tech.Services;

namespace ACP_Tech.Controllers
{
    public class AlunosController : Controller
    {
        private readonly AlunoService _alunoService;

        public AlunosController(AlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        
        // GET: Alunos
        public IActionResult Index()
        {  
            var list = _alunoService.PesquisarTodos();
            return View(list);            
        } 
        
        public IActionResult Create() 
        {
            return View();
        }


    }

}
