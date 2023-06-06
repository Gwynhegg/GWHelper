namespace GWHelper.Infrastructure.Services.Interfaces
{
    public interface IDbService<T>
    {
        void AddItem(T item);
        T GetItem(string id);
        T GetItem(int id);
        void RemoveItem(string id);
        void RemoveItem(int id);
        void UpdateItem(T item);
    }
}