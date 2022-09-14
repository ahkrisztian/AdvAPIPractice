using AdvAPIPractice.Models;
using AdvAPIPractice.Services;
using Microsoft.AspNetCore.Http.Features;
using System;

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
            if (advertiser == null)
            {
                throw new ArgumentNullException(nameof(advertiser));
            }

            _context.Advertisers.Add(advertiser);
            _context.SaveChanges();
        }

        public void DeleteAdvertiser(Advertiser advertiser)
        {
            if (advertiser == null)
            {
                throw new ArgumentNullException(nameof(advertiser));
            }

            _context.Advertisers.Remove(advertiser);
            _context.SaveChanges();
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
