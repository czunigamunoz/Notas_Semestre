using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasSesmestre
{
    class Funciones
    {   public int BuscarCaracter(string Entrada, char t, int Desde)
        { if(Desde<0)
            Desde = 0;
          while(Desde<Entrada.Length && Entrada[Desde] !=t)
              Desde++;
          return Desde;
        }

        public string CopiarDesdeHasta(string Entrada, int inicio, int final)
        {  string tmp = ""; int k;
           if (inicio < 0)
            inicio = 0;
           for (k = inicio; k <= final && k < Entrada.Length; k++)
             tmp += Entrada[k];
           return tmp;           
        }

        public double Acumulado(double n1, double n2, double n3)
        {  return n1*0.3+n2*0.3+n3*.4;
        }

        public double Acumulado(double n1, double n2)
        {  return n1*0.3+n2*0.3;
        }

        public double Acumulado(double n1)
        {  return n1*0.3;
        }
    }
    
}
