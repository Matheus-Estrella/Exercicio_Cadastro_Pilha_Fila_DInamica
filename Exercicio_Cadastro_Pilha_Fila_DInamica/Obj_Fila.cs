using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Cadastro_Pilha_Fila_DInamica
{
    internal class Obj_Fila
    {
        int num;
        Obj_Fila? prox;
        Obj_Fila? prev;

        public Obj_Fila(int num)
        {
            this.num = num;
            this.prox = null;
            this.prev = null;
        }

        public void Set_Prox(Obj_Fila o)
        {
            this.prox = o;
        }
        public Obj_Fila Get_Prox()
        {
            return this.prox;
        }
        public Obj_Fila Get_Prev()
        {
            return this.prev;
        }
        public int Get_Num()
        {
            return this.num;
        }
        public override string? ToString()
        {
            return $" {this.num} ";
        }
    }
}
