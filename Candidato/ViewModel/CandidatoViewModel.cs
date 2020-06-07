using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using System.Security.Cryptography.X509Certificates;
using Candidato.Views;

namespace Candidato.ViewModel
{
    public class CandidatoViewModel : INotifyPropertyChanged
    {
        protected CandidatoPage candidatoPage;
        public ICommand GravarClickedCommand { get; private set; }
        public ICommand LimparClickedCommand { get; private set; }
  

        public CandidatoViewModel()
        {            
            GravarClickedCommand = new Command(() =>
            {
                //var mensagem = "Gravar" + candidatoPage.
               
                // Application.Current.MainPage.DisplayAlert("Titulo", mensagem);
            });

            LimparClickedCommand = new Command(() =>
            {
                
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}