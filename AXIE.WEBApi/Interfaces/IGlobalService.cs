namespace AXIE.WEBApi.Interfaces
{
    public interface IGlobalService<T>
    {
        List<T> GetAll();
        Task<T> GetById(Guid id);
        List<T> Add();
    }
}
