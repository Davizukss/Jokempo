using PedraPapelETesoura.ViewModels;
using Microsoft.Maui.Controls;

namespace PedraPapelETesoura.Views
{
    public partial class JoKenPoView : ContentPage
    {
        public JoKenPoView()
        {
            InitializeComponent();
            BindingContext = new JokenPoViewModel();
        }
    }
}
