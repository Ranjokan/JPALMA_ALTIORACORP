using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ClienteViewModel, Cliente>();
        CreateMap<Cliente, ClienteViewModel>();

        CreateMap<ArticuloViewModel, Articulo>();
        CreateMap<Articulo, ArticuloViewModel>();

        CreateMap<OrdenCompraViewModel, OrdenCompra>();
        CreateMap<OrdenCompra, OrdenCompraViewModel>();

    }

}
