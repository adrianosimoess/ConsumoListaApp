using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            ArrayList lista = new ArrayList();

            foreach (KeyValuePair<string, string> conteudoDaLista in conteudo){
                lista.Add(conteudoDaLista.Key);
            }

            //var listaItens = conteudo.Keys.ToList();
            //for (int i = 0; i < listaItens.Count; i++)
            //{
            //   if(listaItens[i] == "Oraculo")
            //    {
            //       lista.Add(listaItens[i]);
            //    }

            // }

            listaMunicipio.ItemsSource = lista;
        }
    }
}
