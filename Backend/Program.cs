

Console.WriteLine("Cajas Frutos Secos Mixtos\n\n");
Console.WriteLine("1-Crear Caja\n");
Console.WriteLine("2-Listar Cajas\n");
Console.WriteLine("3-Salir\n");

var opcion = Console.ReadLine();


switch (opcion)
{

    case "1":

        CrearCaja();
        break;

    case "2":

        ListarCaja();
        break;

    case "3":

        Console.WriteLine("Saliendo...");
        break;

    default:

        Console.WriteLine("Opcion Invalida");
        Console.WriteLine("Saliendo...");
        break;

}


void CrearCaja(){

    try{

        //Creando una Caja
        Caja caja = new Caja();
        // Caja caja2 = new Caja();

        //Llenando la Caja de Frutos Secos
        caja.SetCajaMixta(2000);
        // caja2.SetCajaMixta(2000);
        // caja.Id = 1;

        //Guardando la caja
        Console.WriteLine(CajasBLL.Insertar("Concepto 1",caja));
        // Console.WriteLine(CajasBLL.Insertar("Concepto 2",caja2));
        // Console.WriteLine(CajasBLL.Insertar("Concepto 3",caja));
        // Console.WriteLine(CajasBLL.Insertar("Concepto 4",caja));
        // Console.WriteLine(CajasBLL.Insertar("Concepto 5",caja));

        // //Convirtiendo la caja a Funditas y eliminando la Caja
        // caja.Id = 1;
        Console.WriteLine(InventarioBLL.GuardarFunditas(CajasBLL.ConvertirCaja()));
        // caja.Id = 2;
        // Console.WriteLine(InventarioBLL.GuardarFunditas(CajasBLL.ConvertirCaja()));
        // caja.Id = 3;
        // Console.WriteLine(InventarioBLL.GuardarFunditas(CajasBLL.ConvertirCaja(caja)));
       
    }
    catch (SystemException e)
    {
        Console.WriteLine(e.Message);
    }

}


void ListarCaja(){

    try{

        Inventario inventario = CajasBLL.GetInventario();

        Console.WriteLine($"Id:{inventario.Id}");
        Console.WriteLine($"Cajas:{InventarioBLL.getCantidadCajas()}");
        Console.WriteLine($"Funditas:{InventarioBLL.getCantidadFunditas()}");
        Console.WriteLine($"Concepto:{inventario.Concepto}\n\n");
        Console.WriteLine($"Fecha Del Inventario:{inventario.Fecha}\n\n");

       
    }
    catch (SystemException e)
    {
        Console.WriteLine(e.Message);
    }

}