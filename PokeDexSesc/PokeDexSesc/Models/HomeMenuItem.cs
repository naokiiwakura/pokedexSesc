using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDexSesc.Models
{
    public enum MenuItemType
    {
        Pokemons,
        Sobre
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
