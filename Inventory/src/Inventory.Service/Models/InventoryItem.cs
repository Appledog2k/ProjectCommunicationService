using System;
using Common;

namespace Inventory.Service.Models
{
    public class InventoryItem : IEntity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid CatalogItemId { get; set; }

        public int Quantity { get; set; }

        public DateTimeOffset AcquiredDate { get; set; }
    }
}