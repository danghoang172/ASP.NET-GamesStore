﻿using System;
using System.Collections.Generic;
using GamesStore.Domain.Entities;

namespace GamesStore.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}