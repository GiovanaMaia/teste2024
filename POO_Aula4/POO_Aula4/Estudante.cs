using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula4
{
    internal class Estudante
    {
        string nome;
        public int turma { get; set; }
        public double mediaNotas{ get; set; }

        public Estudante(string nome, int turma)
        {
            this.nome = nome;
            this.turma = turma;
        }

        public string getNome() 
        { 
            return nome;
        }

        public void setMediasNotas(int novaNota)
        {
            if (novaNota > 0) { this.mediaNotas = novaNota;}
        }
    }
}
