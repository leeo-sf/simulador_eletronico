using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testEletronico
{
    public class Configuracao : Eletronico
    {
        protected bool conectado = false;
        protected bool aviao = false;

        public void Conectar()
        {
            if (!this.ligado)
            {
                Console.WriteLine($"{this.name} não está ligado.");
                return;
            }

            if (conectado)
            {
                Console.WriteLine($"{this.name} JÁ ESTÁ CONECTADO.");
                return;
            }

            Console.WriteLine($"{this.name} conectando...");
            conectado = true;
        }

        public void Desconectar()
        {
            if (!this.ligado)
            {
                Console.WriteLine($"Dispositivo {this.name} não está ligado");
                return;
            }

            if (!conectado)
            {
                Console.WriteLine($"Dispositivo {this.name} não estava conectado.");
                return;
            }

            Console.WriteLine($"{this.name} desconectando...");
            conectado = false;
        }

        public void AtivarModoAviao()
        {
            if (!this.ligado)
            {
                Console.WriteLine($"Dispositivo {this.name} não está ligado");
                return;
            }

            if (conectado)
            {
                conectado = false;
            }

            aviao = true;
            Console.WriteLine($"O modo avião do dispositvo {this.name} foi ativado");
        }

        public void DesativarModoAviao()
        {
            if (!this.ligado)
            {
                Console.WriteLine($"Dispositivo {this.name} não está ligado");
                return;
            }

            if (aviao)
            {
                Console.WriteLine($"Dispositivo {this.name} já estava desconectado.");
                return;
            }

            aviao = false;
            Console.WriteLine($"O modo avião do dispositivo {this.name} foi desatvado.");
        }
    }
}
