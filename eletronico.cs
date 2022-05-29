namespace testEletronico
{
    public class Eletronico
    {
        protected string name = "SmartphoneUsuário";
        protected bool ligado = false;

        public void Ligar()
        {
            if (ligado)
            {
                Console.WriteLine($"Dispositivo {name} já está ligado.");
                return;
            }

            Console.WriteLine($"Dipositivo {name} ligado.");
            ligado = true;
        }

        public void Desligar()
        {
            if (!ligado)
            {
                return;
            }

            Console.WriteLine($"Dispositivo {name} desligando...");
            ligado = false;
        }
    }
}
