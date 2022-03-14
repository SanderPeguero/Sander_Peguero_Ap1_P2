using Microsoft.EntityFrameworkCore;

public class InventarioBLL{
    private static Contexto contexto = new Contexto();

    //Guarda un Inventario con Fecha y Concepto

    public static bool Guardar(DateTime fecha, string concepto){
        
        Inventario inventario = new Inventario();

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
    // public static bool GuardarFunditas(Fundita fundita){
        
    //     bool successfull = false;

    //     if(contexto.Inventario.Count() == 0){
            
    //        successfull = Insertar(DateTime.Now,"Guardando Funditas", fundita);

    //     }else{

    //         Inventario inventario = new Inventario();
            
    //         contexto.Entry(fundita).State = EntityState.Added;

    //         contexto.Entry(inventario).State = EntityState.Added;

    //         successfull = contexto.SaveChanges() > 0;

    //     }

    //     return successfull;

    // }

    public static bool GuardarFunditas(Fundita fundita){
        
        bool successfull = false;

        for(int s = 0; s < 20; s++){
            // Fundita fundita = new Fundita();
            Contexto context = new Contexto();
            // fundita = funditas[s];
            fundita.Id = context.Funditas.First().Id + 1;
            context.Add(fundita);
            context.Entry(fundita).State = EntityState.Added;
            successfull = context.SaveChanges() > 0;
            // context.Dispose();        
        }

        return successfull;

    }

    public static int getCantidadCajas(){

        int cantidad = contexto.Cajas
        .GroupBy(x => x.Id)
        .Select(g => g.Count()).Count();

        return cantidad;
    }

    public static List<Inventario> getLista(){
        
        return contexto.Inventario.ToList();

    }

    public static List<Caja> getListaCaja(){
        return contexto.Cajas.ToList();
    }

    public static List<Fundita> getListaFunditas(){
        return contexto.Funditas.ToList();
    }

    public static int getCantidadFunditas(){

        int cantidad = contexto.Funditas
        .GroupBy(x => x.Id)
        .Select(g => g.Count()).Count();

        return cantidad;
    }

}