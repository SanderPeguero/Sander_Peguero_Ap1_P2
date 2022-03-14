using System.ComponentModel.DataAnnotations;

//LA ENTIDAD CAJA TE AYUDARA CON EL MANEJO DEL CONTENIDO DENTRO DE TUS OBJETOS TIPO CAJA
//--------------------------------------------------------------------------------------

//A continuacion una lista de los metodos que puedes usar,para que sirven y como invocarlos

//CajaMixta: Recibe un peso y llena la caja con partes iguales de Manies,Pistachos,Pasas,Ciruelas y Arandanos
//Invocacion: Obeto.CajaMixta(Peso en valor Int)

//Caja{Fruto}: Recibe un peso y llena la caja de ese Fruto 
//Invocacion: Objeto.Caja{Fruto}(Peso en valor Int)

public class Caja{//Caja que tiene una cantidad de Libras de Frutos Secos

    [Key]
    public int Id {get; set;}

    public DateTime Fecha {get; set;} = DateTime.Now;

    [Required(ErrorMessage = "Campo obligatorio. Se debe indicar el peso.")]    
    public int Peso {get; set;}

    public int Manies {get; set;}

    public int Pistachos {get; set;}

    public int Pasas {get; set;}

    public int Ciruelas {get; set;}
    public int Arandanos {get; set;}

    public void SetCajaMixta(int peso){ //Setter de una Caja de Frutos Mixtos

        this.Manies = peso/5;
        this.Pistachos = peso/5;
        this.Pasas = peso/5;
        this.Ciruelas = peso/5;
        this.Arandanos = peso/5;

        this.Peso = peso;

    }

    public void SetCajaManies(int peso){ //Setter de una Caja de Manies

        Manies = peso;
        Pistachos = 0;
        Pasas = 0;
        Ciruelas = 0;
        Arandanos = 0;

        this.Peso = peso;
        
    }

    public void SetCajaPistachos(int peso){ //Setter de una Caja de Pistachos

        Manies = 0;
        Pistachos = peso;
        Pasas = 0;
        Ciruelas = 0;
        Arandanos = 0;

        this.Peso = peso;

    }

    public void SetCajaPasas(int peso){ //Setter de una Caja de Pasas
        
        Manies = 0;
        Pistachos = 0;
        Pasas = Peso;
        Ciruelas = 0;
        Arandanos = 0;

        this.Peso = peso;

    }

    public void SetCajaCiruelas(int peso){ //Setter de una Caja de Ciruelas

        Manies = 0;
        Pistachos = 0;
        Pasas = 0;
        Ciruelas = peso;
        Arandanos = 0;

        this.Peso = peso;

    }

    public void SetCajaArandanos(int peso){ //Setter de una Caja de Arandanos

        Manies = 0;
        Pistachos = 0;
        Pasas = 0;
        Ciruelas = 0;
        Arandanos = peso;

        Peso = peso;

    }

}
