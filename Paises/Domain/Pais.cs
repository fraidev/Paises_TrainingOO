using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Paises.Domain
{
    public class Pais
    {
        public string Nome { get; set; }
        public string Capital { get; set; }
        public double DimensaoEmKm2 { get; set; }
        public IList<Pais> PaisesEmFronteira { get; set; } = new List<Pais>();

        public Pais(string nome, string capital, double dimensaoEmKm2)
        {
            Nome = nome;
            Capital = capital;
            DimensaoEmKm2 = dimensaoEmKm2;
        }

        public string GetNome()
        {
            return Nome;
        }
        
        public string GetCapital()
        {
            return Capital;
        }
        
        public double GetDimensaoEmKm2()
        {
            return DimensaoEmKm2;
        }

        public bool EhIgual(Pais outroPais)
        {
            return (Nome == outroPais.Nome && Capital == outroPais.Capital);
        }

        public void SetPaisesEmFronteira(Pais pais)
        {
            if (Nome != pais.Nome && Capital != pais.Capital)
            {
                PaisesEmFronteira.Add(pais);
            }
            //TODO Exception 
        }
        public IList<Pais> GetPaisesEmFronteira()
        {
            return PaisesEmFronteira;
        }

        public IList<Pais> GetPaisesVizinhos(Pais pais)
        {
            return pais.PaisesEmFronteira.Where(paises => this.PaisesEmFronteira.Contains(paises)).ToList();
        }
    }
}