using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace AppsBindable.Views
{
    public class Teste : ContentPage
    {
        Picker pckEstado;
        Button btnPegarValor;
        Label lblValor;

        public Teste()
        {
            SetupUI();
            SetupEventHandler();
        }

        private void SetupEventHandler()
        {
            btnPegarValor.Clicked += (sender, e) =>
            {
                if (pckEstado.SelectedIndex != -1)
                {
                    var itemSelecionado = pckEstado.Items[pckEstado.SelectedIndex];
                    //var valor = pckEstado.ElementAt(pckEstado.SelectedIndex);

                    if (!string.IsNullOrEmpty(itemSelecionado))
                    {
                        lblValor.Text = itemSelecionado;
                    }                    
                }
                else
                {
                    lblValor.Text = "Selecione um Estado";
                }
            };
        }

        private void SetupUI()
        {
            pckEstado = new Picker { Title = "Estado" };
            pckEstado.Items.Add("SP");
            pckEstado.Items.Add("RJ");
            pckEstado.Items.Add("DF");
            pckEstado.Items.Add("RS");

            btnPegarValor = new Button { Text = "Pegar Valor" };
            lblValor = new Label { };

            this.Content = new StackLayout
            {
                Children = {
                    pckEstado,
                    btnPegarValor,
                    lblValor
                }
            };
        }
    }
}
