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
    public class CandidatoViewModel
    {
        protected CandidatoPage candidatoPage;
        CandidatoModel cand = new CandidatoModel();
        //protected CandidatoModel candidatoModel;
        public ICommand GravarCommand { get; private set; }
        public ICommand LimparCommand { get; private set; }


        public CandidatoViewModel()
        {
            GravarCommand = new Command(() =>
            {
                var mensagem = "Gravar" + "Nome --> " + cand.NomeCandidato + "\n"
                + "Sobrenome --> " + cand.SobrenomeCandidato + "\n"
                + "Email --> " + cand.EmailCandidato + "\n"
                + "Resumo Profissional --> " + cand.EditorProfissional + "\n"
                + "Pretencao Salarial --> R$ " + cand.PretencaoCandidato + "\n";

                Application.Current.MainPage.DisplayAlert("Gravar", mensagem, "Ok");

            });

            LimparCommand = new Command(() =>
            {
                cand.NomeCandidato = "";
                cand.SobrenomeCandidato = "";
                cand.EmailCandidato = "";
                cand.EditorProfissional = "";
                cand.PretencaoCandidato = 0;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
      
        }
    
}