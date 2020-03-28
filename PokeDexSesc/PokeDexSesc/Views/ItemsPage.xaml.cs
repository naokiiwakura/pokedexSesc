using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PokeDexSesc.Models;
using PokeDexSesc.Views;
using PokeDexSesc.ViewModels;
using PokeDexSesc.Services;

namespace PokeDexSesc.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;
        PokemonService _pokemonService;

        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ItemsViewModel();
            _pokemonService = new PokemonService();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.IsBusy = true;
        }


        public async void BuscaPokemon(object sender, EventArgs e)
        {
            var pokemon = await _pokemonService.BuscarPokemon(txtPokemon.Text);

            if(pokemon == null)
            {
                await DisplayAlert("Aviso", "O Pokemon não foi encontrado", "Ok");
                return;
            }

            imgPokemon.Source = pokemon.sprites.front_default;
        }
    }
}