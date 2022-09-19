using AdvAPIPractice.Controllers;
using AdvAPIPractice.Data;
using AdvAPIPractice.DTOs;
using AdvAPIPractice.Models;
using AdvAPIPractice.Profiles;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AdvAPIPracticeTest
{
    [TestClass]
    public class AdvAPITest
    {
        private Mock<IAdvertisementRepo> _advrepo;
        private Mock<IAdvertiserRepo> _adviserrepo;
        AdvertiserProfiles realprofile;
        MapperConfiguration _mapperConfiguration;
        IMapper _mapper;


        [TestInitialize]
        public void InitializeTests()
        {
            _advrepo = new Mock<IAdvertisementRepo>();
            _adviserrepo = new Mock<IAdvertiserRepo>();
            realprofile = new AdvertiserProfiles();
            _mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile(realprofile));
            _mapper = new Mapper(_mapperConfiguration);


            var articles = new List<Advertisement>()
            {
                new Advertisement
                {
                    Id = 1,
                    Description = "big cube",
                    ImageURL = "https//",
                    AdvertiserId = 1,
                    Size = "S"

                },
                new Advertisement
                {
                    Id = 2,
                    Description = "small cube",
                    ImageURL = "https//",
                    AdvertiserId = 1,
                    Size = "S"

                },
                new Advertisement
                {
                    Id = 3,
                    Description = "small cube",
                    ImageURL = "https//",
                    AdvertiserId = 2,
                    Size = "M"

                }
            };

            string[] temp = new string[] { "small" };

            _advrepo.Setup(m => m.GetAdvertisementByKeyWords(1, "S", temp)).Returns(new Advertisement
            {
                Id = 2,
                Description = "small cube",
                ImageURL = "https//",
                AdvertiserId = 1,
                Size = "S"
            });
        }

        [TestMethod]
        public void TestGetAdvs()
        {
            string[] temp = new string[] { "small" };

            var adv = new AdvertiserController(null, _advrepo.Object, _mapper);

            var result = adv.GetAdvertisementByKeyWords(1, "S", temp);

            var res = result.Result as OkObjectResult;

            var articles = res.Value as AdvertisementReadDTO;

            Assert.IsNotNull(result);
            Assert.AreEqual(articles.Id, 2);
        }

    }
}