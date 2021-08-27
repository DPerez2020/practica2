using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace practica2.Pages
{
    public class nominaModel : PageModel
    {        
        public List<Empleado> empleados { get; set; }       
        public void OnGet()
        {
            empleados = new List<Empleado>()
            {
                new Empleado(){nombre="Dawin",apellido="Perez",cargo="Desarrollador",salario=60000},
                new Empleado(){nombre="Plinion",apellido="Palmer",cargo="Desarrollador",salario=30000},
                new Empleado(){nombre="Jose",apellido="Matias",cargo="Administrador de proyecto",salario=90000},
                new Empleado(){nombre="Michael",apellido="Ventura",cargo="Arquitecto",salario=100000},
                new Empleado(){nombre="Lewis",apellido="Perez",cargo="QA",salario=40000},
                new Empleado(){nombre="Gabriela",apellido="Rodriguez",cargo="DBA",salario=120000}
            };
        }
    }
    public class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cargo { get; set; }
        public decimal salario { get; set; }
    }
}
