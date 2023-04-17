﻿namespace SalesNet.Shared.Entities
{
    public class TemporalSaleDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public float Quantity { get; set; } = 1;

        public string Remarks { get; set; } = string.Empty;
    }
}

