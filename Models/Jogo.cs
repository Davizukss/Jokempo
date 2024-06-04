using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace PedraPapelETesoura.Models
    {
        public static class Jogo
        {
            public static string Jogar(Opcao escolhaJogador, Opcao escolhaComputador)
            {
                if (escolhaJogador == escolhaComputador)
                {
                    return "Empate!";
                }
                else if ((escolhaJogador == Opcao.PEDRA && escolhaComputador == Opcao.TESOURA) ||
                         (escolhaJogador == Opcao.PAPEL && escolhaComputador == Opcao.PEDRA) ||
                         (escolhaJogador == Opcao.TESOURA && escolhaComputador == Opcao.PAPEL))
                {
                    return "Você venceu!";
                }
                else
                {
                    return "Você perdeu!";
                }
            }

            public static Opcao EscolhaComputador()
            {
                var random = new Random();
                return (Opcao)random.Next(3);
            }
        }
    }
