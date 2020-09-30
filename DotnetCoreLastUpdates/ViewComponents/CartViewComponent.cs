using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCoreLastUpdates.ViewComponents
{
    [ViewComponent(Name = "Cart")]
    public class CartViewComponent : ViewComponent
    {
        public int ItensCart { get; set; }

        public CartViewComponent()
        {
            ItensCart = 3;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ItensCart);
        }
    }
}