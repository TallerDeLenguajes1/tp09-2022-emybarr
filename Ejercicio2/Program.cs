using System.Text.Json;
using System.Text.Json.Serialization;


namespace Ejercicio2
{
    public class Program{
  
        static void Main(string[] args)
        {
           int cant; 
           List<productos> listProductos = new List<productos>();
         
           Console.WriteLine("Ingrese la cantidad de productos : ");
           cant = Convert.ToInt32(Console.ReadLine());
           for (int i = 0; i < cant ; i++){
             listProductos.Add(productos.crearProductos());
           }

           foreach(productos prod in listProductos){
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Nombre : " + prod.Nombre);
            Console.WriteLine("Precio :" + prod.Precio);
            Console.WriteLine("Fecha de Vencimeinto : " + prod.Fechadevencimiento);
            Console.WriteLine("Tamanio :" + prod.Tamanio);

           }
           string archivonombre = "productos.json";
           File.WriteAllText("productos.json",JsonSerializer.Serialize(listProductos));
           
           string jsonlista = File.ReadAllText(archivonombre);
           listProductos = JsonSerializer..Deserialize<List<listproductos>>(jsonlista);

           foreach(var p in listProductos){
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Nombre : " + prod.Nombre);
            Console.WriteLine("Precio :" + prod.Precio);
            Console.WriteLine("Fecha de Vencimeinto : " + prod.Fechadevencimiento);
            Console.WriteLine("Tamanio :" + prod.Tamanio);


           }
        
}
}
}