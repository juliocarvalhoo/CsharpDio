namespace ClassPooInit.Models
{
    public class Retangulo
    {
        private double Comprimento;
        private double Largura;

        public void DefinirMedidas(double comprimento, double largura)
        {
            this.Comprimento = comprimento;
            this.Largura = largura;

        }
        public double ObterArea()
        {
            return Comprimento * Largura;
        }
    }
}