using System.Text.Json;
using System.Text.Json.Serialization;


namespace Ejercicio2
{
    public class Program{
  
        static void Main(string[] args)
        {
           int cant; 
           int g;
           List<productos> listProductos = new List<productos>();
           var manejoArchivos = new manejoArchivo();
         
           Console.WriteLine("Ingrese la cantidad de productos : ");
           cant = Convert.ToInt32(Console.ReadLine());
           for (int i = 0; i < cant ; i++){
             listProductos.Add(productos.crearProductos());
           }
<<<<<<< HEAD
           
           string archivonombre = "productos.json";
           File.WriteAllText("productos.json",JsonSerializer.Serialize(listProductos));
           
           string jsonlista = File.ReadAllText(archivonombre);
           listProductos = JsonSerializer..Deserialize<List<listproductos>>(jsonlista);

           foreach(var p in listProductos){
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Nombre : " + p.Nombre);
            Console.WriteLine("Precio :" + p.Precio);
            Console.WriteLine("Fecha de Vencimeinto : " + p.Fechadevencimiento);
=======

           foreach(productos prod in listProductos){
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Nombre : " + prod.Nombre);
            Console.WriteLine("Precio :" + prod.Precio);
            Console.WriteLine("Fecha de Vencimeinto : " + prod.Fechadevencimiento.ToShortDateString());
            Console.WriteLine("Tamanio :" + prod.Tamanio);

           }

           string archivo = "productos.json";
           string produJson =JsonSerializer.Serialize(listProductos);
           manejoArchivos.GuardarArchivoTexto(archivo,produJson);

           string jsonP = manejoArchivos.AbrirArchivoTexto(archivo);
           var listaJson = JsonSerializer.Deserialize<List<productos>>(jsonP);
          
            Console.WriteLine("------------------Lista Json------------------------");
            foreach(productos p in listaJson){
            Console.WriteLine("Nombre : " + p.Nombre);
            Console.WriteLine("Precio :" + p.Precio);
            Console.WriteLine("Fecha de Vencimeinto : " + p.Fechadevencimiento.ToShortDateString());
>>>>>>> 76ce5e63149cfecf3436b0f6ebaf4baaa26f60b7
            Console.WriteLine("Tamanio :" + p.Tamanio);

           }
         
}
     
        }
  
}
