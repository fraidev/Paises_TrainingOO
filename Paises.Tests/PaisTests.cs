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
            
            Assert.AreEqual(brasil.Nome,"Brasil" );
        }
    }
}