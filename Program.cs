namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            testEletronico.Configuracao obj = new testEletronico.Configuracao();

            obj.Ligar();
            obj.Conectar();
            obj.AtivarModoAviao();
            obj.Ligar();
        }
    }
}
