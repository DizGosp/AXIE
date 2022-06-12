namespace AXIE.WEBApi.Interfaces
{
    public interface IGlobalService<T>
    {
        List<T> GetAll();
        Task<T> GetById(Guid id);
        Task<bool> Add(T request);
    }
}
