using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumoListaApp.Model;
using Xamarin.Forms;

namespace ConsumoListaApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }



        void Handle_Clicked(object sender, System.EventArgs e)
        {

            Dictionary<string, string> conteudo = new Dictionary<string, string>();
            conteudo.Add("Professor", "Ramon");
            conteudo.Add("Aluno", "Michel Temer");
            conteudo.Add("Mito", "Lula");
            conteudo.Add("Oraculo", "Dilma");

           // ArrayList lista = new ArrayList();

            List<Mestre> listamestre = new List<Mestre>();

            foreach (KeyValuePair<string, string> conteudoDaLista in conteudo){

                Mestre mestre = new Mestre();

                mestre.nome = conteudoDaLista.Value;
                mestre.tipo = conteudoDaLista.Key;

                listamestre.Add(mestre);

            }


            listaMunicipio.ItemsSource = listamestre;
        }
    }
}
