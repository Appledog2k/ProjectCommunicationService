using System;

namespace Catalog.Service.Services
{
    public record CatalogItemCreated(Guid itemId, string name, string description);
    public record CatalogItemUpdated(Guid itemId, string name, string description);
    public record CatalogItemDeleted(Guid itemId);

}