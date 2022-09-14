using AdvAPIPractice.DTOs;
using AdvAPIPractice.Models;
using AutoMapper;

namespace AdvAPIPractice.Profiles
{
    public class AdvertiserProfiles : Profile
    {
        public AdvertiserProfiles()
        {
            CreateMap<Advertiser, AdvertiserReadDTO>();
            CreateMap<Advertisement, AdvertisementReadDTO>();
        }
    }
}
