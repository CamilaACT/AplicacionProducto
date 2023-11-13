namespace AplicacionProducto;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;


public partial class ProductoPage : ContentPage
{
	public ProductoPage()
	{
		InitializeComponent();
		listaProductos.ItemsSource = Utils.Utils.ListaProductos;
	}
	private async void OnclickNuevoProducto(object sender, EventArgs e)
	{
		var toast = Toast.Make("On click Boton Nuevo Producto", ToastDuration.Short, 14);
		await toast.Show();
	}
}