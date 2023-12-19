using AutoMapper;
using HShop.Data;
using HShop.ViewModels;

namespace HShop.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterVM, KhachHang>(); /*mapping from RegisterVM to KhachHang*/
            /*                .ForMember(kh => kh.HoTen, option => option.MapFrom(RegisterVM => RegisterVM.HoTen))
                            .ReverseMap();*/
        }
    }
}
