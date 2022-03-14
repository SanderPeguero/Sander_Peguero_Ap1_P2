using Microsoft.EntityFrameworkCore;
public class FunditasBLL{
    private static Contexto contexto = new Contexto();

    public static bool Guardar(int peso){
        
        Fundita fundita = new Fundita();

        fundita.Peso = peso;
        
        bool successfull = false;

        contexto.Add(fundita);
        contexto.Entry(fundita).State = EntityState.Added;
        successfull = contexto.SaveChanges() > 0;

        return successfull;

    }

}