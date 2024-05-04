using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Cadastro_Pilha_Fila_DInamica
{
    internal class Obj_Pilha
    {
        int num;
        Obj_Pilha prox;

        public Obj_Pilha(int num){ this.num = num;}
        public void Set_Prox(Obj_Pilha o)
        {
            this.prox = o;
        }
        public Obj_Pilha Get_Prox()
        {
            return this.prox;
        }
        public int Get_Num()
        {
            return this.num;
        }
        public override string? ToString()
        {
            return $" {num} ";
        }

    }
}
