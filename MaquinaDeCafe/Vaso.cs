namespace MaquinaDeCafe
{
    public class Vaso
    {
        private int cantidadVasos;
        private int contenido;

        public Vaso(int cantidadVasos, int contenido)
        {
            this.cantidadVasos = cantidadVasos;
            this.contenido = contenido;
        }

        public bool hasVasos(int cantidadVasos)
        {
            return this.cantidadVasos >= cantidadVasos;
        }

        public void giveVasos(int cantidadVasos)
        {
            this.cantidadVasos -= cantidadVasos;
        }

        public int getCantidadVasos()
        {
            return cantidadVasos;
        }

        public int getContenido()
        {
            return contenido;
        }
    }
}