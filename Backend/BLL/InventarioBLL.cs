using Microsoft.EntityFrameworkCore;

public class InventarioBLL{
    private static Contexto contexto = new Contexto();

    //Guarda un Inventario con Fecha y Concepto
    public static bool Insertar(DateTime fecha, string concepto){
        
        Inventario inventario = new Inventario();
        
        Console.WriteLine(contexto.Inventario.Last().Id);

        // inventario.Id = contexto.Inventario.Last().Id + 1;
        inventario.Fecha = fecha;
        inventario.Concepto = concepto;

        contexto.Inventario.Add(inventario);

        contexto.Entry(inventario).State = EntityState.Added;

        return contexto.SaveChanges() > 0;
        
    }

    //Guarda un Inventario con Fecha, Concepto y Fundita
    public static bool Insertar(DateTime Fecha, string Concepto, Fundita fundita){

        Inventario inventario = new Inventario();

        inventario.Concepto = Concepto;
        
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
            
            contexto.Entry(fundita).State = EntityState.Added;

            contexto.Entry(inventario).State = EntityState.Added;

            successfull = contexto.SaveChanges() > 0;

        }

        return successfull;

    }

    public static bool GuardarFunditas(List<Fundita> funditas){
        
        bool successfull = false;

        for(int s = 0; s < funditas.Count(); s++){
            Fundita fundita = new Fundita();
            Contexto context = new Contexto();
            fundita = funditas[s];
            context.Entry(fundita).State = EntityState.Added;
            successfull = context.SaveChanges() > 0;
            context.Dispose();        
        }

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