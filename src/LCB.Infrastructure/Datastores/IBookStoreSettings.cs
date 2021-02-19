namespace LCB.Infrastructure.Datastores
{
    public interface IBookStoreSettings
    {
        string BooksCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
