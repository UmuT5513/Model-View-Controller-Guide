using AutoMapper;
using hafta3.ViewModels;

namespace hafta3.Mapping
{
    public class ViewModelMapping:Profile
    {
        public ViewModelMapping()
        {
            CreateMap<Models.Product, ProductViewModel>().ReverseMap();
        }
    }
}
