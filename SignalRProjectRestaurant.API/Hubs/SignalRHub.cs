using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Context;
using SignalR.EntityLayer.Entities.Concrete;
using SignalRProjectRestaurant.EntityLayer.Concrete;

namespace SignalRProjectRestaurant.API.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IClientTableService _clientTableService;
        private readonly IMoneyCaseService _moneyCaseService;

        public SignalRHub(ICategoryService categoryService, IOrderService orderService, IProductService productService, IClientTableService clientTableService, IMoneyCaseService moneyCaseService)
        {
            _categoryService = categoryService;
            _orderService = orderService;
            _productService = productService;
            _clientTableService = clientTableService;
            _moneyCaseService = moneyCaseService;
        }

        public async Task SendStatistics()
        {
            var category1 = _categoryService.TCategoryCount();
            var category2 = _categoryService.TActiveCategoryCount();
            var category3 = _categoryService.TPassiveCategoryCount();
            var clientTable1 = _clientTableService.TClientTableCount();
            var moneyCase1 = _moneyCaseService.TTotalMoneyCaseAmount();

            var order1 = _orderService.TTotalOrderCount();
            var order2 = _orderService.TActiveOrderCount();
            var order3 = _orderService.TPassiveOrderCount();
            var order4 = _orderService.TLastOrderPrice();
            var order5 = _orderService.TTodayTotalPrice();


            var product1 = _productService.TProductCount();
            var product2 = _productService.TProductCountByCategoryNameHamburger();
            var product3 = _productService.TProductCountByCategoryNameDrink();
            var product4 = _productService.TMostPriceProduct();
            var product5 = _productService.TLeastPriceProduct();
            var product6 = _productService.TAveragePrice();
            var product7 = _productService.TAverageHamburgerPrice();

            await Clients.All.SendAsync("ReceiveTotalOrderCount", order1);
            await Clients.All.SendAsync("ReceiveActiveOrderCount", order2);
            await Clients.All.SendAsync("ReceivePassiveOrderCount", order3);
            await Clients.All.SendAsync("ReceiveLastOrderPrice", order4);
            await Clients.All.SendAsync("ReceiveTodayTotalPrice", order5);

            await Clients.All.SendAsync("ReceiveClientTableCount", clientTable1);

            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", moneyCase1.ToString("0.00")+"₺");

            await Clients.All.SendAsync("ReceiveCategoryCount", category1);
            await Clients.All.SendAsync("ActiveCategoryCount", category2);
            await Clients.All.SendAsync("PassiveCategoryCount", category3);
            await Clients.All.SendAsync("ReceiveProductCount", product1);
            await Clients.All.SendAsync("ProductCountByCategoryNameHamburger", product2);
            await Clients.All.SendAsync("ProductCountByCategoryNameDrink", product3);
            await Clients.All.SendAsync("ReceiveMostPriceProduct", product4.ProductName);
            await Clients.All.SendAsync("ReceiveLeastPriceProduct", product5.ProductName);
            await Clients.All.SendAsync("ReceiveAveragePrice", product6.ToString("0.00") + "₺");
            await Clients.All.SendAsync("ReceiveAverageHamburgerPrice", product7.ToString("0.00") + "₺");

        }



        public async Task SendProgress()
        {
            var moneyCase1= _moneyCaseService.TTotalMoneyCaseAmount;

            await Clients.All.SendAsync("Receive", moneyCase1);
        }
    }
}
