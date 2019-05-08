using System;
using System.Collections.Generic;
using System.Linq;
using GamesStore.Domain.Entities;

namespace GamesStore.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}