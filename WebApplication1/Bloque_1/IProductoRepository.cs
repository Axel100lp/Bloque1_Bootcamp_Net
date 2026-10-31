namespace ConsoleApp1;

public interface IProductoRepository {

    void AgregarProducto(Producto producto);
    List<Producto> ObtenerTodos();
    Producto ObtenerPorId(int id);
    List<Producto> BuscarPorCategoria(string categoria);
}
