using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.CompilerServices;

namespace Candidato.Model
{
    public class CandidatoModel : INotifyPropertyChanged
    {

        private String nomeCandidato;
        public String NomeCandidato
        {
            get { return nomeCandidato; }
            set
            {
                if (nomeCandidato != value)
                {
                    nomeCandidato = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private String sobrenomeCandidato;
        public String SobrenomeCandidato
        {
            get { return sobrenomeCandidato; }
            set
            {
                if (sobrenomeCandidato != value)
                {
                    sobrenomeCandidato = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String emailCandidato;
        public String EmailCandidato
        {
            get { return emailCandidato; }
            set
            {
                if (emailCandidato != value)
                {
                    emailCandidato = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private String editorProfissional;
        public String EditorProfissional
        {
            get { return editorProfissional; }
            set
            {
                if (editorProfissional != value)
                {
                    editorProfissional = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int pretencaoCandidato;
        public int PretencaoCandidato
        {
            get { return pretencaoCandidato; }
            set
            {
                if (pretencaoCandidato != value)
                {
                    pretencaoCandidato = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

     /*   public CandidatoModel()
        {
        }

        public CandidatoModel(String Nome, String Sobrenome, String Email, String Profissao, int PretSal)
        {
            this.nomeCandidato = Nome;
            this.sobrenomeCandidato = Sobrenome;
            this.emailCandidato = Email;
            this.editorProfissional = Profissao;
            this.pretencaoCandidato = PretSal;
        }
     */
    }
}
