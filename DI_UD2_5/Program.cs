using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD2_5
{
    public class Tarea
    {
        public string Titulo { get; set; }
        public bool Completada { get; set; }

        public Tarea(string titulo)
        {
            Titulo = titulo;
            Completada = false;
        }
    }

    public class AgendaTareas
    {
        private List<Tarea> tareas = new List<Tarea>();

        public void AgregarTarea(Tarea tarea) => tareas.Add(tarea);

        public void EliminarTarea(string titulo) => tareas.RemoveAll(t => t.Titulo == titulo);

        public void CompletarTarea(string titulo)
        {
            var tarea = tareas.Find(t => t.Titulo == titulo);
            if (tarea != null) tarea.Completada = true;
        }

        public void ListarTareas()
        {
            foreach (var tarea in tareas)
                Console.WriteLine($"{tarea.Titulo} - {(tarea.Completada ? "Completada" : "Pendiente")}");
        }

        public void BuscarTarea(string titulo)
        {
            var tarea = tareas.Find(t => t.Titulo == titulo);
            Console.WriteLine(tarea != null ? $"{tarea.Titulo} - {(tarea.Completada ? "Completada" : "Pendiente")}" : "Tarea no encontrada");
        }
    }

    public class Program
    {
        public static void Main()
        {
            AgendaTareas agenda = new AgendaTareas();
            agenda.AgregarTarea(new Tarea("Estudiar para el examen"));
            agenda.ListarTareas();

            agenda.CompletarTarea("Estudiar para el examen");
            agenda.BuscarTarea("Estudiar para el examen");

            agenda.EliminarTarea("Estudiar para el examen");
            agenda.ListarTareas();
        }
    }
}
