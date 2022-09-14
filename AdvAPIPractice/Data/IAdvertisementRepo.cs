using AdvAPIPractice.Models;

namespace AdvAPIPractice.Data
{
    public interface IAdvertisementRepo
    {
        IEnumerable<Advertisement> GetAdvertisementByAdvertiser(Advertiser advertiser);
        Advertisement GetAdvertisementByKeyWords(int id, string size, string[] keywords);

        IEnumerable<Advertisement> GetAdvertisementByAdvertiserId(int id);
        void CreateAdvertisement(Advertisement advertisement);
        void UpdateAdvertisement(Advertisement advertisement);
        void DeleteAdvertisement(Advertisement advertisement);
    }
}
