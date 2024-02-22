using AutoMapper;

public interface IOrdenCompraService
{
    OrdenCompra CrearOrdenCompra(List<DetalleOrdenCompraViewModel> detallesOrdenCompraViewModel);
}

public class OrdenCompraService
{
    private readonly IOrdenCompraRepository _ordenCompraRepository;
    private readonly IClienteRepository _clienteRepository;
    private readonly IMapper _mapper;

    public OrdenCompraService(IOrdenCompraRepository ordenCompraRepository, IMapper mapper, IClienteRepository clienteRepository)
    {
        _ordenCompraRepository = ordenCompraRepository;
        _clienteRepository = clienteRepository;
        _mapper = mapper;
    }

    public OrdenCompra CrearOrdenCompra(OrdenCompraViewModel ordenCompraViewModel)
    {

        var orden = _mapper.Map<OrdenCompra>(ordenCompraViewModel);

        _ordenCompraRepository.IngresarOrdenCompra(orden);
        return orden;
    }
}
