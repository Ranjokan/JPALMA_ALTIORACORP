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

    public List<ArticuloViewModel> ObtenerTodosArticulos()
    {
        var articulos = _articuloRepository.ObtenerTodosArticulos();
        return _mapper.Map<List<ArticuloViewModel>>(articulos);
    }

    public ArticuloViewModel ObtenerArticuloPorCodigo(string codigoArticulo)
    {
        var articulo = _articuloRepository.ObtenerArticuloPorCodigo(codigoArticulo);
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

    public ArticuloViewModel Modificararticulo(string codigoArticulo, ArticuloViewModel ArticuloViewModel)
    {
        if (ArticuloViewModel == null)
        {
            throw new ArgumentNullException(nameof(ArticuloViewModel), "El modelo de vista del articulo no puede ser nulo.");
        }

        var articuloExistente = _articuloRepository.ObtenerArticuloPorCodigo(codigoArticulo);

        if (articuloExistente == null)
        {
            throw new InvalidOperationException($"No se encontró el articulo con codigo {codigoArticulo}");
        }

        _mapper.Map(ArticuloViewModel, articuloExistente);
        _articuloRepository.ModificarArticulo(codigoArticulo,articuloExistente);
        return ArticuloViewModel;
    }

    
}
