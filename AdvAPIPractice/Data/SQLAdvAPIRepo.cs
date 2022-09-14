using AdvAPIPractice.Models;
using AdvAPIPractice.Services;
using Microsoft.AspNetCore.Http.Features;

namespace AdvAPIPractice.Data
{
    public class SQLAdvAPIRepo : IAdvertiserRepo
    {
        private readonly AppDbContext _context;

        public SQLAdvAPIRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateAdvertiser(Advertiser advertiser)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdvertiser(Advertiser advertiser)
        {
            throw new NotImplementedException();
        }

        public Advertiser GetAdvertiserById(int id)
        {
            AddAdvertisementsToContext(id);           

            return _context.Advertisers.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Advertiser> GetAllAdvertiser()
        {
            AddAdvertisements();

            return _context.Advertisers.ToList();
        }

        public void UpdateAdvertiser(Advertiser advertiser)
        {
            throw new NotImplementedException();
        }

        public void AddAdvertisementsToContext(int id)
        {
            _context.Advertisements.ToList().Where(a => a.AdvertiserId == id);
        }

        public void AddAdvertisements()
        {
            _context.Advertisements.ToList();
        }
    }
}
