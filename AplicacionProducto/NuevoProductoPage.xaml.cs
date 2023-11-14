using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System;

namespace AplicacionProducto;

public partial class NuevoProductoPage : ContentPage
{
    public NuevoProductoPage()
    {
        InitializeComponent();


    }
    private async void OnclickGuardarProducto(object sender, EventArgs e)
    {
        int id = Utils.Utils.ListaProductos.Count+1;
        Utils.Utils.ListaProductos.Add(new Models.Producto
        {
            IdProducto = id,
            Nombre=Nombre.Text,
            Descripcion=Descripcion.Text,
            cantidad =Int32.Parse(cantidad.Text),
        });
        var tamaño = Utils.Utils.ListaProductos.Count;
        Console.WriteLine($"Tamaño de la lista de productos");
        await Navigation.PopModalAsync();
    }
}