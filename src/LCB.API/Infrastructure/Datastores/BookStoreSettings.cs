using LCB.Infrastructure.Datastores;

namespace LCB.API.Infrastructure.Datastores
{
    public class BookStoreSettings : IBookStoreSettings
    {
        public string BooksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
