namespace AXIE.WEBApi.Interfaces
{
    public interface IGlobalService<T>
    {
        List<T> GetAll();
        T GetById();
        List<T> Add();
    }
}
