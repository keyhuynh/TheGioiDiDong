using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasm.Shared
{
    public partial class MainLayout
    {
        [Inject] NavigationManager Navigation { get; set; }
        private string keyword;

        public void SearchProduct()
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                Navigation.NavigateTo($"search/{keyword}");
                keyword = null;
            }

        }
    }
}
