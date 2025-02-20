namespace Play.Catalog.Contracts
{
    public record CatalogItemCreated(Guid ItemId, string Name, string Description);
    public record CatalogItemDeleted(Guid ItemId);
    public record CatalogItemUpdate(Guid ItemId, string Name, string Description);
}