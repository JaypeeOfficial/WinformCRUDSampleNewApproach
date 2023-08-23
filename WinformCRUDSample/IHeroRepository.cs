namespace WinformCRUDSample
{
    public interface IHeroRepository
    {
        Task<IEnumerable<Hero>> GetAll();
        Task Add(Hero hero);
        Task Update(Hero hero); 
        Task Delete(Hero hero);
    }
}