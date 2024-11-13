using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula4
{
    internal class Turma
    {
        public int ID { get; }
        List<Estudante> estudantes = new List<Estudante>();

        public Turma(int iD)
        {
            ID = iD;    
        }

        public void setEstudante (Estudante e)
        {
            estudantes.Add(e);
        }
        public void mostrarEstudantes()
        {
            foreach (var estudante in estudantes)
            {
                Console.WriteLine(estudante.getNome());
            }
        }
        public void cadastrarNota (int iD, int novaNota)
        {
            estudantes[iD].setMediasNotas(novaNota);
        }
        public void acessarNota(int iD)
        {
            Console.WriteLine(estudantes[iD].mediaNotas);
        }

    }
}
