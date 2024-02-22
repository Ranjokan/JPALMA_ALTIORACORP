using AutoMapper;

public class ClienteService
{
    private readonly IClienteRepository _clienteRepository;
    private readonly IMapper _mapper;

    public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
    {
        _clienteRepository = clienteRepository;
        _mapper = mapper;
    }

    public List<ClienteViewModel> ObtenerTodosClientes()
    {
        var clientes = _clienteRepository.ObtenerTodosClientes();
        return _mapper.Map<List<ClienteViewModel>>(clientes);
    }

    public ClienteViewModel ObtenerClientePorDNI(string dni)
    {
        var cliente = _clienteRepository.ObtenerClientePorDNI(dni);
        return _mapper.Map<ClienteViewModel>(cliente);
    }

    public ClienteViewModel IngresarCliente(ClienteViewModel clienteViewModel)
    {
        if (clienteViewModel == null)
        {
            throw new ArgumentNullException(nameof(clienteViewModel), "El modelo de vista del cliente no puede ser nulo.");
        }

        var cliente = _mapper.Map<Cliente>(clienteViewModel);
        _clienteRepository.IngresarCliente(cliente);
        return clienteViewModel;
    }

    public ClienteViewModel ModificarCliente(string dni, ClienteViewModel clienteViewModel)
    {
        if (clienteViewModel == null)
        {
            throw new ArgumentNullException(nameof(clienteViewModel), "El modelo de vista del cliente no puede ser nulo.");
        }

        var clienteExistente = _clienteRepository.ObtenerClientePorDNI(dni);

        if (clienteExistente == null)
        {
            throw new InvalidOperationException($"No se encontró el cliente con DNI {dni}");
        }

        _mapper.Map(clienteViewModel, clienteExistente);
        _clienteRepository.ModificarCliente(dni,clienteExistente);
        return clienteViewModel;
    }

public ClienteViewModel EliminarCliente(string dni)
    {
        ClienteViewModel clienteEliminado = new();
        var clienteExistente = _clienteRepository.ObtenerClientePorDNI(dni);

        if (clienteExistente == null)
        {
            throw new InvalidOperationException($"No se encontró el cliente con DNI {dni}");
        }

        _clienteRepository.EliminarCliente(clienteExistente);
        _mapper.Map(clienteExistente,clienteEliminado);
        return clienteEliminado;
    }
    
}
