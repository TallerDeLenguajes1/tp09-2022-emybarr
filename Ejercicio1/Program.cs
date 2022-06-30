
Console.WriteLine("Ingrese un carpeta");

string carpeta = Console.ReadLine();

List<string>listaCarpeta = new List<string>();
List<string>listaArchivos = new List<string>();


if(Directory.Exists(carpeta)){
    foreach(string carpe in Directory.GetDirectories(carpeta)){
        listaCarpeta.Add(carpe);
    }  
    foreach(string carpe in Directory.GetFiles(carpeta)){
        listaArchivos.Add(carpe);
    } 
      
}else{
    Console.WriteLine("No existe la carpeta");
}

 Console.WriteLine("--------------");

 Console.WriteLine("Lista archivos");
 int i = 0;

 Console.WriteLine("Lista archivos");

 foreach(string a in listaArchivos){
    
    Console.WriteLine( i + " "+ Path.GetFileNameWithoutExtension(a) + " "+ Path.GetExtension(a));
    i++;
   
}

 int j=0;
 
  string nombreArchivo = "index.json";
        {
             using(var archivo = new FileStream(nombreArchivo, FileMode.Create))
            {
                using (var strWriter = new StreamWriter(archivo))
                {
                    foreach(string a in listaArchivos)
                    {
                     string ext = Path.GetExtension(a);
                     string namefile = Path.GetFileNameWithoutExtension(a);
                     string texto = j + " " + namefile + " " + ext + " , ";
                     strWriter.WriteLine("{0}", texto);
                     j++;
                   
                }
                    strWriter.Close();
                    archivo.Close();
                  
            }
             
        }
        
        }
        
        
        