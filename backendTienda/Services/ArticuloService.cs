using AutoMapper;

public class ArticuloService
{
    private readonly IArticuloRepository _articuloRepository;
    private readonly IMapper _mapper;

    public ArticuloService(IArticuloRepository articuloRepository, IMapper mapper)
    {
        _articuloRepository = articuloRepository;
        _mapper = mapper;
    }

    public List<ArticuloViewModel> ObtenerTodosarticulos()
    {
        var articulos = _articuloRepository.ObtenerTodosarticulos();
        return _mapper.Map<List<ArticuloViewModel>>(articulos);
    }

    public ArticuloViewModel ObtenerarticuloPorDNI(string dni)
    {
        var articulo = _articuloRepository.ObtenerarticuloPorDNI(dni);
        return _mapper.Map<ArticuloViewModel>(articulo);
    }

    public ArticuloViewModel Ingresararticulo(ArticuloViewModel ArticuloViewModel)
    {
        if (ArticuloViewModel == null)
        {
            throw new ArgumentNullException(nameof(ArticuloViewModel), "El modelo de vista del articulo no puede ser nulo.");
        }

        var articulo = _mapper.Map<Articulo>(ArticuloViewModel);
        _articuloRepository.IngresarArticulo(articulo);
        return ArticuloViewModel;
    }

    public ArticuloViewModel Modificararticulo(string dni, ArticuloViewModel ArticuloViewModel)
    {
        if (ArticuloViewModel == null)
        {
            throw new ArgumentNullException(nameof(ArticuloViewModel), "El modelo de vista del articulo no puede ser nulo.");
        }

        var articuloExistente = _articuloRepository.ObtenerarticuloPorDNI(dni);

        if (articuloExistente == null)
        {
            throw new InvalidOperationException($"No se encontró el articulo con DNI {dni}");
        }

        _mapper.Map(ArticuloViewModel, articuloExistente);
        _articuloRepository.Modificararticulo(dni,articuloExistente);
        return ArticuloViewModel;
    }

public ArticuloViewModel Eliminararticulo(string dni)
    {
        ArticuloViewModel articuloEliminado = new();
        var articuloExistente = _articuloRepository.ObtenerarticuloPorDNI(dni);

        if (articuloExistente == null)
        {
            throw new InvalidOperationException($"No se encontró el articulo con DNI {dni}");
        }

        _articuloRepository.Eliminararticulo(articuloExistente);
        _mapper.Map(articuloExistente,articuloEliminado);
        return articuloEliminado;
    }
    
}
