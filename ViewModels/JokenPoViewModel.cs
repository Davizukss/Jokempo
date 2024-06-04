using CommunityToolkit.Mvvm.ComponentModel;
using PedraPapelETesoura.Models;
using System.Windows.Input;

namespace PedraPapelETesoura.ViewModels
{
    public partial class JokenPoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string playerName;

        [ObservableProperty]
        private Jogador player;

        [ObservableProperty]
        private Jogador robo;

        [ObservableProperty]
        private Opcao escolha;

        [ObservableProperty]
        private string result;

        public ICommand MakeChoiceCommand { get; }

        public JokenPoViewModel()
        {
            Player = new Jogador("Jogador");
            Robo = new Jogador("Máquina");
            MakeChoiceCommand = new Command<Opcao>(MakeChoice);
        }

        private void MakeChoice(Opcao escolha)
        {
            Player.Escolha = escolha;
            Robo.Escolha = (Opcao)new Random().Next(0, 3);

            DetermineWinner();
        }

        private void DetermineWinner()
        {
            if (Player.Escolha == Robo.Escolha)
            {
                Result = "Empate!";
            }
            else if ((Player.Escolha == Opcao.PEDRA && Robo.Escolha == Opcao.TESOURA) ||
                     (Player.Escolha == Opcao.PAPEL && Robo.Escolha == Opcao.PEDRA) ||
                     (Player.Escolha == Opcao.TESOURA && Robo.Escolha == Opcao.PAPEL))
            {
                Player.Pontuacao++;
                Result = $"{Player.Nome} Venceu!";
            }
            else
            {
                Robo.Pontuacao++;
                Result = $"{Robo.Nome} Venceu!";
            }

            OnPropertyChanged(nameof(Player));
            OnPropertyChanged(nameof(Robo));
        }
    }
}
