using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudante e1 = new Estudante("Beatriz", 34);
            Turma t1 = new Turma(34);
            Console.WriteLine(t1.ID);
            t1.setEstudante(e1);
            t1.setEstudante(new Estudante("Mateus", 34));

            e1.setMediasNotas(99);

            t1.mostrarEstudantes();

            t1.cadastrarNota(1, 80);
            t1.acessarNota(1);



        }
    }
}
