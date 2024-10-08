﻿namespace Flavorful.Core.Entities
{
    public class CustomerBasket
    {
        public string Id { get; set; }
        public List<BasketItem> Items { get; set; }
        public int? DeliveryMethodId { get; set; }
        public decimal ShippingPrice { get; set; }
        public string? PaymentIntentId { get; set; }
        public string? ClientSecret { get; set; }
        public CustomerBasket(string id)
        {
            Id = id;
            //for 0 on cart
            Items = new List<BasketItem>();
        }
    }
}
