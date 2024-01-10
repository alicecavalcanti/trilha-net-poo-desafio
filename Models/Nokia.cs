namespace DesafioPOO.Models
{
    
    public class Nokia: Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
        public override string ToString()
        {
            return "********** Smartphone Nokia *********** \n" +
                    "Número: " + Numero +
                    "| Modelo: " + getModelo();
        }
        
    }
}
