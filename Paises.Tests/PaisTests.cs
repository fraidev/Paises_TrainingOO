using NUnit.Framework;
using Paises.Domain;

namespace Paises.Tests
{
    public class PaisTests
    {
        [Test]
        public void Deve_Criar_Pais()
        {
            var brasil = new Pais("Brasil", "Brasilia", 500);

            Assert.AreEqual(brasil.Nome, "Brasil");
        }

        //Eh Igual
        [Test]
        public void Deve_Retornar_False_Se_Paises_Tiverem_Nome_E_Capital_Difentes()
        {
            var brasil = new Pais("Brasil", "Brasilia", 8516000);
            var eua = new Pais("Estados Unidos", "Washington", 9834000);

            Assert.False(brasil.EhIgual(eua));
        }

        [Test]
        public void Deve_Retornar_True_Se_Paises_Tiverem_Nome_E_Capitals_Iguais()
        {
            var brasil = new Pais("Brasil", "Brasilia", 8516000);
            var outroPais = new Pais("Brasil", "Brasilia", 9834000);

            Assert.True(brasil.EhIgual(outroPais));
        }

        //Paises em Fronteira
        [Test]
        public void Deve_Adicionar_Paises_Em_Fronteira()
        {
            var brasil = new Pais("Brasil", "Brasilia", 8516000);
            var outroPais = new Pais("Outro Pais", "Outra Cidade", 9834000);

            brasil.SetPaisesEmFronteira(outroPais);

            Assert.AreEqual(brasil.PaisesEmFronteira[0], outroPais);
        }
        
        //Get Paises em Froteira
        [Test]
        public void Deve_Retornar_Paises_em_Froteira()
        {
            var brasil = new Pais("Brasil", "Brasilia", 8516000);
            var outroPais = new Pais("Outro Pais", "Outra Cidade", 9834000);
            var outroPais2 = new Pais("Outro Pais2", "Outra Cidade2", 9834000);
            var outroPais3 = new Pais("Outro Pais3", "Outra Cidade3", 9834000);
            
            brasil.SetPaisesEmFronteira(outroPais);
            brasil.SetPaisesEmFronteira(outroPais2);
            brasil.SetPaisesEmFronteira(outroPais3);

            Assert.AreEqual(brasil.PaisesEmFronteira.Count, 3);
        }
        
        //Get Paises Vizinhos
        [Test]
        public void Deve_Retornar_Paises_Vizinhos_Em_Comum()
        {
            var brasil = new Pais("Brasil", "Brasilia", 8516000);
            var eua = new Pais("Estados Unidos", "Washington", 9834000);
            
            var outroPais = new Pais("Outro Pais", "Outra Cidade", 9834000);
            var outroPais2 = new Pais("Outro Pais2", "Outra Cidade2", 9834000);
            var outroPais3 = new Pais("Outro Pais3", "Outra Cidade3", 9834000);
            
            brasil.SetPaisesEmFronteira(outroPais);
            brasil.SetPaisesEmFronteira(outroPais2);
            brasil.SetPaisesEmFronteira(outroPais3);
            
            eua.SetPaisesEmFronteira(outroPais);
            eua.SetPaisesEmFronteira(outroPais3);

            var lista = brasil.GetPaisesVizinhos(eua);

            Assert.AreEqual(eua.PaisesEmFronteira, lista);
            Assert.AreNotEqual(brasil.PaisesEmFronteira, lista);
        }
    }
}