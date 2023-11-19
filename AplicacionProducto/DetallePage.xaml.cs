using AplicacionProducto.Models;

namespace AplicacionProducto;

public partial class DetallePage : ContentPage
{
    private Producto _producto;
	public DetallePage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _producto = BindingContext as Producto;
        Nombre.Text = _producto.Nombre;
        Cantidad.Text = _producto.cantidad.ToString();
        Descripcion.Text = _producto.Descripcion;
    }
    private async void OnclickEditarProducto(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NavigationPage(new NuevoProductoPage()
        {
            BindingContext = _producto,
        })) ;
    }
    private async void OnclickBorrarProducto(object sender, EventArgs e)
    {
        Utils.Utils.ListaProductos.Remove(_producto);
        await Navigation.PopAsync();

    }
}