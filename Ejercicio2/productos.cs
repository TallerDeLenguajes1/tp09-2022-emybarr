namespace Ejercicio2
{
    public class productos
    {
        private string nombre;
        private DateTime fechadevencimiento;
        private float precio;
        private string tamanio;

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fechadevencimiento { get => fechadevencimiento; set => fechadevencimiento = value; }
        public float Precio { get => precio; set => precio = value; }
        public string Tamanio { get => tamanio; set => tamanio = value; }

         public static productos crearProductos(){
        
        Random rand = new Random();
        productos nuevoProducto= new productos();
        Console.WriteLine("ingrese nombre");
        nuevoProducto.Nombre = Console.ReadLine();
        Console.WriteLine("ingrese fecha de Vencimiento");
        nuevoProducto.Fechadevencimiento= DateTime.Parse(Console.ReadLine());
        nuevoProducto.Precio = rand.Next(1000,5000);
        Console.WriteLine("ingrese tamanio");
        nuevoProducto.Tamanio = Console.ReadLine();
        return nuevoProducto;

    }

    }

   
}