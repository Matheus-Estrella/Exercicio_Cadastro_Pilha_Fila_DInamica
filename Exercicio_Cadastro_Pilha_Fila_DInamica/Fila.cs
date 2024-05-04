using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Cadastro_Pilha_Fila_DInamica
{
    internal class Fila
    {
        Obj_Fila? head;
        Obj_Fila? tail;

        public Fila()
        {
            this.head = null;
            this.tail = null;
        }

        public bool Vazia()
        {
            return (this.head == null && this.tail == null);
        }

        public void Push()
        {
            Random random = new Random();
            Obj_Fila aux = new Obj_Fila(random.Next(1,101));
            if (!Vazia())
            {
                tail.Set_Prox(aux);
                tail = aux;
            }
            else
            {
                head = tail = aux;
            }
        }
        
        public void Print()
        {
            Obj_Fila aux = this.head;
            do
            {
                Console.Write(aux.ToString());
                aux = aux.Get_Prox();
            } while(aux != null);
        }
    }
}
