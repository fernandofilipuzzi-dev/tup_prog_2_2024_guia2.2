using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_Encuesta.Models
{
    public class ProcesoEncuestas
    {
        ArrayList contactables = new ArrayList();
        public int CantContactables
        {
            get
            {
                return contactables.Count;
            }
        }

        int cantBicleta;
        int cantAuto;
        int cantTranspPublico;
        int cantEncuestas;

        public double PorcBicleta
        {
            get
            {
                double porc = 0;
                if (cantEncuestas > 0)
                    porc = 100d * cantBicleta / cantEncuestas;
                return porc;
            }
        }
        public double PorcAuto
        {
            get
            {
                double porc = 0;
                if (cantEncuestas > 0)
                    porc = 100d * cantAuto / cantEncuestas;
                return porc;
            }
        }
        public double PorcTranspPublico
        {
            get
            {
                double porc = 0;
                if (cantEncuestas > 0)
                    porc = 100d * cantTranspPublico / cantEncuestas;
                return porc;
            }
        }

        public ProcesoEncuestas()
        {
            contactables = new ArrayList();
        }

        public void RegistrarEncuesta(Encuesta nuevo, bool puedeSerCantactado)
        {
            cantEncuestas++;

            if (nuevo.UsaBicicleta) cantBicleta++;
            if (nuevo.UsaAuto) cantAuto++;
            if (nuevo.UsaTransportePublico) cantTranspPublico++;

            if (puedeSerCantactado == true)
            {
                contactables.Add(nuevo);
            }
        }

        public Encuesta VerContactable(int idx)
        {
            Encuesta buscado = null;
            if (idx >= 0 && idx < CantContactables)
            {
                buscado = contactables[idx] as Encuesta;
            }
            return buscado;
        }

        public void OrdernarEncuestables()
        {
            QuickSort(contactables, 0, CantContactables - 1);
        }

        void QuickSort(ArrayList lista, int inicio, int fin)
        {
            if (fin >= inicio)
            {
                //partición
                Encuesta p = lista[inicio] as Encuesta;
                int m = inicio + 1;
                int n = fin;

                while (m <= n)//hasta que se crucen
                {
                    while (m <= fin && p.DistanciaASuDestino >= (lista[m] as Encuesta).DistanciaASuDestino) m++;
                    while (n > inicio && p.DistanciaASuDestino <= (lista[n] as Encuesta).DistanciaASuDestino) n--;

                    if (m < n)
                    {
                        object aux = lista[m];
                        lista[m] = lista[n];
                        lista[n] = aux;
                    }
                }
                lista[inicio] = lista[n];
                lista[n] = p;
                //fin partición

                if (inicio < n - 1)
                    QuickSort(lista, inicio, n - 1);
                if (n + 1 < fin)
                    QuickSort(lista, n + 1, fin);
            }
        }
    }
}
