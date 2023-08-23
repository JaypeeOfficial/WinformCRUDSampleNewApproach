using Microsoft.EntityFrameworkCore;

namespace WinformCRUDSample
{
    public class HeroRepository : IHeroRepository
    {
        private readonly StoreContext _context;
        public HeroRepository(StoreContext context)
        {

            _context = context;

        }

        public async Task Add(Hero hero)
        {
            _context.Heroes.Add(hero);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Hero hero)
        {
            _context.Heroes.Remove(hero);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Hero>> GetAll()
        {
            return await _context.Heroes.ToListAsync();
        }

        public async Task Update(Hero hero)
        {
            _context.Update(hero);
            await _context.SaveChangesAsync();
        }
    }
}