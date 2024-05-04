using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Cadastro_Pilha_Fila_DInamica
{
    internal class Pilha
    {
        Obj_Pilha topo;

        public Pilha()
        {
            this.topo = null;
        }
        public Obj_Pilha Push()
        {
            Random random = new Random();
            Obj_Pilha aux = new Obj_Pilha(random.Next(1,101));
            aux.Set_Prox(topo);
            topo = aux;
            return aux;
        }
        public void Print()
        {
            Obj_Pilha aux = topo;
            do
            {
                Console.Write(aux.ToString());
                aux = aux.Get_Prox();
            } while (aux != null);
        }
    }
}
