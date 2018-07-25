using System.Collections.Generic;

namespace Paises.Domain
{
    public class Pais
    {
        public string Nome { get; set; }
        public string Capital { get; set; }
        public double DimensaoEmKm2 { get; set; }
        public IList<Pais> PaisesEmFronteira { get; set; }

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

        public bool SaoIguais(Pais outroPais)
        {
            return (Nome == outroPais.Nome && Capital == outroPais.Capital);
        }
    }
}