namespace AXIE.WEBApi.Interfaces
{
    public interface IGlobalService<T>
    {
        IList<T> GetAll();
        IList<T> GetById();
        IList<T> Add();
    }
}
