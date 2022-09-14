using AdvAPIPractice.Models;

namespace AdvAPIPractice.Data
{
    public interface IAdvertiserRepo
    {
        IEnumerable<Advertiser> GetAllAdvertiser();
        Advertiser GetAdvertiserById(int id);
        void CreateAdvertiser(Advertiser advertiser);
        void UpdateAdvertiser(Advertiser advertiser);
        void DeleteAdvertiser(Advertiser advertiser);

    }
}
