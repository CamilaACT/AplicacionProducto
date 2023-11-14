namespace AplicacionProducto;

using AplicacionProducto.Models;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Collections.ObjectModel;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
	{
		InitializeComponent();
        //listaProductos.ItemsSource = Utils.Utils.ListaProductos;
        listaProductos.ItemsSource = new ObservableCollection<Producto>(Utils.Utils.ListaProductos);

    }
    private async void OnclickNuevoProducto(object sender, EventArgs e)
	{
        try
        {
            await Navigation.PushModalAsync(new NuevoProductoPage());
            var toast = Toast.Make("On click Boton Nuevo Producto", ToastDuration.Short, 14);
            await toast.Show();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al navegar a NuevoProductoPage: {ex.Message}");
        }

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        //listaProductos.ItemsSource = Utils.Utils.ListaProductos;
        listaProductos.ItemsSource = new ObservableCollection<Producto>(Utils.Utils.ListaProductos);
    }

}