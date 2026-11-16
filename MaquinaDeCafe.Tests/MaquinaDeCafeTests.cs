using Xunit;
using Maquina = MaquinaDeCafe.MaquinaDeCafe;

namespace MaquinaDeCafe.Tests
{
    public class MaquinaDeCafeTests
    {
        Cafetera cafetera;
        Vaso vasosPequeno;
        Vaso vasosMediano;
        Vaso vasosGrande;
        Azucarero azucarero;
        Maquina maquinaDeCafe;

        public MaquinaDeCafeTests()
        {
            cafetera = new Cafetera(50);
            vasosPequeno = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azucarero = new Azucarero(20);

            maquinaDeCafe = new Maquina();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequeno(vasosPequeno);
            maquinaDeCafe.setVasosMediano(vasosMediano);
            maquinaDeCafe.setVasosGrande(vasosGrande);
            maquinaDeCafe.setAzucarero(azucarero);
        }

        [Fact]
        public void DeberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaDeCafe.getTipoDeVaso("pequeno");
            Assert.Equal(maquinaDeCafe.vasosPequeno, vaso);
        }

        [Fact]
        public void DeberiaDevolverUnVasoMediano()
        {
            Vaso vaso = maquinaDeCafe.getTipoDeVaso("mediano");
            Assert.Equal(maquinaDeCafe.vasosMediano, vaso);
        }

        [Fact]
        public void DeberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaDeCafe.getTipoDeVaso("grande");
            Assert.Equal(maquinaDeCafe.vasosGrande, vaso);
        }

        [Fact]
        public void DeberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquinaDeCafe.getTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 10, 2);
            Assert.Equal("No hay Vasos", resultado);
        }

        [Fact]
        public void DeberiaDevolverNoHayCafe()
        {
            cafetera = new Cafetera(5);
            maquinaDeCafe.setCafetera(cafetera);

            Vaso vaso = maquinaDeCafe.getTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 2);
            Assert.Equal("No hay Cafe", resultado);
        }

        [Fact]
        public void DeberiaDevolverNoHayAzucar()
        {
            azucarero = new Azucarero(2);
            maquinaDeCafe.setAzucarero(azucarero);

            Vaso vaso = maquinaDeCafe.getTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.Equal("No hay Azucar", resultado);
        }

        [Fact]
        public void DeberiaRestarCafe()
        {
            Vaso vaso = maquinaDeCafe.getTipoDeVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.Equal(40, maquinaDeCafe.getCafetera().getCantidadCafe());
        }

        [Fact]
        public void DeberiaRestarVaso()
        {
            Vaso vaso = maquinaDeCafe.getTipoDeVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.Equal(4, maquinaDeCafe.getVasosPequeno().getCantidadVasos());
        }

        [Fact]
        public void DeberiaRestarAzucar()
        {
            Vaso vaso = maquinaDeCafe.getTipoDeVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.Equal(17, maquinaDeCafe.getAzucarero().getCantidadAzucar());
        }

        [Fact]
        public void DeberiaDevolverFelicitaciones()
        {
            Vaso vaso = maquinaDeCafe.getTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.Equal("Felicitaciones", resultado);
        }
    }
}