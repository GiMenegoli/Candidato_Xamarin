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
using Candidato.Model;

namespace Candidato.ViewModel
{
    public class CandidatoViewModel : INotifyPropertyChanged
    {
        protected CandidatoPage candidatoPage;
        private CandidatoModel candidato = new CandidatoModel();

        public CandidatoModel _candidato;
        public CandidatoModel Candidato
        {
            get { return _candidato; } 
            
            set
            {
                _candidato = value;
                NotifyPropertyChanged();
            }
        }



        public ICommand GravarCommand { get; private set; }
        public ICommand LimparCommand { get; private set; }


        public CandidatoViewModel()
        {
            Candidato = new CandidatoModel();
            GravarCommand = new Command(() =>
            {
                var mensagem = "Nome --> " + Candidato.NomeCandidato + "\n"
                + "Sobrenome --> " + Candidato.SobrenomeCandidato + "\n"
                + "Email --> " + Candidato.EmailCandidato + "\n"
                + "Resumo Profissional --> " + Candidato.EditorProfissional + "\n"
                + "Pretencao Salarial --> R$ " + Candidato.PretencaoCandidato + "\n";

                Application.Current.MainPage.DisplayAlert("Gravar", mensagem, "Ok");

            });

            LimparCommand = new Command(() =>
            {
                Candidato.NomeCandidato = "";
                Candidato.SobrenomeCandidato = "";
                Candidato.EmailCandidato = "";
                Candidato.EditorProfissional = "";
                Candidato.PretencaoCandidato = 0;
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}