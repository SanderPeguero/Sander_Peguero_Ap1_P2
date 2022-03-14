using System.ComponentModel.DataAnnotations;

public class Fundita{

    [Key]
    public int Id {get; set;}

    public DateTime Fecha {get; set;} = DateTime.Now;
    
    public int Peso {get; set;}

    public int Manies {get; set;}

    public int Pistachos {get; set;}

    public int Pasas {get; set;}

    public int Ciruelas {get; set;}
    public int Arandanos {get; set;}

    public void SetFunditaMixta(int peso){ //Setter de una Fundita de Frutos Mixtos

        this.Manies = peso/5;
        this.Pistachos = peso/5;
        this.Pasas = peso/5;
        this.Ciruelas = peso/5;
        this.Arandanos = peso/5;

        this.Peso = peso;

    }

}