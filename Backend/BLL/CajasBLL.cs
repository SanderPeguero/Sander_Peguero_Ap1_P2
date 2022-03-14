using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

public class CajasBLL{

    public static Contexto contexto = new Contexto();

    public static bool Insertar(string concepto, Caja caja){
        
        bool successfull = false;

        Inventario inventario = new Inventario();
        
        inventario.Concepto = concepto;
        
        contexto.Inventario.Add(inventario);

        contexto.Cajas.Add(caja);

        contexto.Entry(caja).State = EntityState.Added;
        
        contexto.Entry(inventario).State = EntityState.Added;

        successfull = contexto.SaveChanges() > 0;

        return successfull;

    }

    public static Inventario GetInventario(){

        return contexto.Inventario.FirstOrDefault();

    }

    public static List<Fundita> ConvertirCaja(){
        
        List<Fundita> funditas = new List<Fundita>();

        Fundita fundita = new Fundita();

        Inventario inventario = contexto.Inventario.First();

        Caja caja = contexto.Cajas.First();

        int peso = caja.Peso;

        contexto.Database.ExecuteSqlRaw($"Delete FROM Cajas Where Id={CountCaja()}");

        contexto.SaveChanges();

        fundita.SetFunditaMixta(peso/20);

        for(int s = 0; s < 20; s++){

            funditas.Add(fundita);
            Console.WriteLine("Culeteando las Fundas");

        }

        return funditas;

    }

    public static int CountCaja(){

        int cantidad = contexto.Cajas
        .GroupBy(x => x.Id)
        .Select(g => g.Count()).Count();

        return cantidad;

    }


}

