using AppModel;
using BlazorWasm.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasm.Pages
{
    public partial class Index
    {
        [Inject] private IProductApiClient ProductApiClient { set; get; }
        private List<Product> Products;
        private bool showProduct = true;// biến hiển thị sản phẩm
        protected string Coordinates { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductApiClient.GetProducts();
        }
        
        private void ShowHideProduct()
        {
            showProduct = !showProduct;//khi chạy hàm này sẽ đổi trạng thái ngược lại chính nó
        }

        protected void Mouse_Move(MouseEventArgs e)
        {
            Coordinates = $"X = {e.ClientX }, Y = {e.ClientY}"; 
        }
    }
}
