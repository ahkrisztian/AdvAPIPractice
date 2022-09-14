using AdvAPIPractice.Models;
using AdvAPIPractice.Services;

namespace AdvAPIPractice.Data
{
    public class SQLAdvertisementRepo : IAdvertisementRepo
    {
        private readonly AppDbContext _context;

        public SQLAdvertisementRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateAdvertisement(Advertisement advertisement)
        {
            throw new NotImplementedException();
        }

        public void DeleteAdvertisement(Advertisement advertisement)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Advertisement> GetAdvertisementByAdvertiser(Advertiser advertiser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Advertisement> GetAdvertisementByAdvertiserId(int id)
        {
            throw new NotImplementedException();
        }

        public Advertisement GetAdvertisementByKeyWords(int id, string size, string[] keywords)
        {
            int tempCounter = 0;

            int counter = 0;

            Advertisement advertisement = new Advertisement();

            var temp = _context.Advertisements.ToList().Where(a => a.AdvertiserId == id && a.Size == size);

            foreach (var tempItem in temp)
            {
                tempCounter = 0;

                foreach (var keyword in keywords)
                {
                    if (tempItem.Description.Contains(keyword))
                    {
                        tempCounter++;
                       
                    }

                    if(tempCounter > counter)
                    {
                        advertisement = tempItem;
                        counter = tempCounter;
                    }

                    if (advertisement == null)
                    {
                        advertisement = tempItem;
                    }
                }
            }

            return advertisement;
        }

        public void UpdateAdvertisement(Advertisement advertisement)
        {
            throw new NotImplementedException();
        }
        
    }
}
