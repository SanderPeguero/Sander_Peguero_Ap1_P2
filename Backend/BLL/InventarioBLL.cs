using Microsoft.EntityFrameworkCore;

public class InventarioBLL{
    private static Contexto contexto = new Contexto();

    //Guarda un Inventario con Fecha y Concepto
    public static bool Insertar(DateTime fecha, string concepto){
        
        Inventario inventario = new Inventario();
        
        Console.WriteLine(contexto.Inventario.Last().Id);

        inventario.Id = contexto.Inventario.Last().Id + 1;
        inventario.Fecha = fecha;
        inventario.Concepto = concepto;

        contexto.Inventario.Add(inventario);

        contexto.Entry(inventario).State = EntityState.Added;

        return contexto.SaveChanges() > 0;
        
    }

    //Guarda un Inventario con Fecha, Concepto y Fundita
    public static bool Insertar(DateTime Fecha, string Concepto, Fundita fundita){

        Inventario inventario = new Inventario();

        // inventario.Id = contexto.Inventario.ToList().Count + 1;
        inventario.Concepto = Concepto;
        // inventario.Funditas.Add(fundita);

        // contexto.Inventario.Add(inventario);
        
        contexto.Entry(fundita).State = EntityState.Added;
        contexto.Entry(inventario).State = EntityState.Added;


        return contexto.SaveChanges() > 0;

    }


    //Guarda un Inventario con Fecha, Concepto, Caja y Fundita
    public static bool GuardarFunditas(Fundita fundita){
        
        bool successfull = false;

        if(contexto.Inventario.Count() == 0){
            
           successfull = Insertar(DateTime.Now,"Guardando Funditas", fundita);

        }else{

            Inventario inventario = new Inventario();

            // inventario = contexto.Inventario.First();

            // inventario.Funditas.Add(fundita);

            // contexto.Inventario.Add(inventario);
            
            contexto.Entry(fundita).State = EntityState.Added;

            contexto.Entry(inventario).State = EntityState.Added;

            successfull = contexto.SaveChanges() > 0;

            Console.WriteLine("Culete");

        }

        return successfull;

    }

    public static bool GuardarFunditas(List<Fundita> funditas){
        
        bool successfull = false;

        // Inventario inventario = new Inventario();

        // inventario = contexto.Inventario.First();
        // fundita.Id = contexto.Funditas.Count() + 1;

        for(int s = 0; s < funditas.Count(); s++){
            Fundita fundita = new Fundita();
            Contexto context = new Contexto();
            fundita = funditas[s];
            // fundita.Id = fundita.Id + s;
            //contexto.Funditas.Add(fundita);
            context.Entry(fundita).State = EntityState.Added;
            successfull = context.SaveChanges() > 0;
            context.Dispose();        
        }


        // contexto.Entry(funditas).State = EntityState.Added;
        

        // inventario.Funditas = funditas;

        Console.WriteLine("Termino el guardado Culete");

        return successfull;

    }

    public static int getCantidadCajas(){

        int cantidad = contexto.Cajas
        .GroupBy(x => x.Id)
        .Select(g => g.Count()).Count();

        return cantidad;
    }

    public static int getCantidadFunditas(){

        int cantidad = contexto.Funditas
        .GroupBy(x => x.Id)
        .Select(g => g.Count()).Count();

        return cantidad;
    }

}