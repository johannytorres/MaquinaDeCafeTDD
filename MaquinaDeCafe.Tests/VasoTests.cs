using Xunit;

namespace MaquinaDeCafe.Tests
{
    public class VasoTests
    {
        [Fact]
        public void DeberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(2, 10);

            bool resultado = vasosPequenos.hasVasos(1);

            Assert.Equal(true, resultado);
        }

        [Fact]
        public void DeberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(1, 10);

            bool resultado = vasosPequenos.hasVasos(2);

            Assert.Equal(false, resultado);
        }

        [Fact]
        public void DeberiaRestarCantidadDeVaso()
        {
            Vaso vasosPequenos = new Vaso(5, 10);

            vasosPequenos.giveVasos(1);

            Assert.Equal(4, vasosPequenos.getCantidadVasos());
        }
    }
}