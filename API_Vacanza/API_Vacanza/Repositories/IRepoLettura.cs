namespace API_Vacanza.Repositories
{
    public interface IRepoLettura<T>
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);

    }
}