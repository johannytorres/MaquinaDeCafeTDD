using System;

namespace MaquinaDeCafe
{
    public class MaquinaDeCafe
    {
        public Cafetera cafetera = null!;
        public Vaso vasosPequeno = null!;
        public Vaso vasosMediano = null!;
        public Vaso vasosGrande = null!;
        public Azucarero azucarero = null!;

        public void setCafetera(Cafetera cafetera) { this.cafetera = cafetera; }
        public void setVasosPequeno(Vaso vaso) { vasosPequeno = vaso; }
        public void setVasosMediano(Vaso vaso) { vasosMediano = vaso; }
        public void setVasosGrande(Vaso vaso) { vasosGrande = vaso; }
        public void setAzucarero(Azucarero azucarero) { this.azucarero = azucarero; }

        public Cafetera getCafetera() { return cafetera; }
        public Azucarero getAzucarero() { return azucarero; }
        public Vaso getVasosPequeno() { return vasosPequeno; }

        public Vaso getTipoDeVaso(string tipoDeVaso)
        {
            switch (tipoDeVaso)
            {
                case "pequeno": return vasosPequeno;
                case "mediano": return vasosMediano;
                case "grande": return vasosGrande;
                default: throw new ArgumentException("Tipo de vaso no valido");
            }
        }

        public string getVasoDeCafe(Vaso vaso, int cantidadDeVasos, int cantidadDeAzucar)
        {
            int cafeNecesario = vaso.getContenido() * cantidadDeVasos;

            if (!vaso.hasVasos(cantidadDeVasos)) return "No hay Vasos";
            if (!cafetera.hasCafe(cafeNecesario)) return "No hay Cafe";
            if (!azucarero.hasAzucar(cantidadDeAzucar)) return "No hay Azucar";

            vaso.giveVasos(cantidadDeVasos);
            cafetera.giveCafe(cafeNecesario);
            azucarero.giveAzucar(cantidadDeAzucar);

            return "Felicitaciones";
        }
    }
}