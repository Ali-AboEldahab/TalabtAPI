﻿namespace Talabat.APIs.DTOs
{
    public class CustomerBasketDro
    {
        [Required]
        public string Id { get; set; }
        public List<BasketItemDto> Items { get; set; }
    }
}
