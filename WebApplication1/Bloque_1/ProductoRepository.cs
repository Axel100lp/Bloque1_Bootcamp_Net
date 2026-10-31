using System;

namespace ConsoleApp1;

public class ProductoRepository : IProductoRepository {

public List<Producto> listaProductos{ get; private set; }

public ProductoRepository() {
    listaProductos = new List<Producto>();
}

public void AgregarProducto(Producto p_producto) {
    this.listaProductos.Add(p_producto);
}
public void quitrarProducto(Producto p_producto) {
    this.listaProductos.Remove(p_producto);
}

public List<Producto> ObtenerTodos() {
    return this.listaProductos;
}

public Producto ObtenerPorId(int id) {
    Producto auxProducto = this.listaProductos.FirstOrDefault(p => p.Id == id);

    if(auxProducto == null) {
        //keyNotFoundException es una excepción que se lanza cuando no se encuentra un 
        // elemento en una colección basandose en el ide
        throw new KeyNotFoundException($"No se encontró un producto con el id {id}");
    }
    return auxProducto;
}

public List<Producto> BuscarPorCategoria(string categoria) {
    return this.listaProductos.Where(p => p.Descripcion == categoria).ToList();
}



}