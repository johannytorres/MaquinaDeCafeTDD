namespace MaquinaDeCafe
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }

        public bool hasCafe(int cantidadCafe)
        {
            return this.cantidadCafe >= cantidadCafe;
        }

        public void giveCafe(int cantidadCafe)
        {
            this.cantidadCafe -= cantidadCafe;
        }

        public int getCantidadCafe()
        {
            return cantidadCafe;
        }
    }
}