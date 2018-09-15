using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Itemindicador.Models
{
    public class ItemViewModel
    {
        public ItemIndicador item { get; set; }
        public List<ItemIndicador> itens { get; set; }
    }
}