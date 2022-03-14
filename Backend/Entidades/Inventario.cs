using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// En el inventario se registran las cajas y funditas 
public class Inventario{

    [Key]
    public int Id {get; set;}

    public DateTime Fecha {get; set;} = DateTime.Now;

    public string Concepto {get; set;}

    // [ForeignKey("Id")]
    // public List<Fundita> Funditas {get; set;} = new List<Fundita>();
    
    
    // [ForeignKey("Id")]
    // public List<Caja> Cajas {get; set;} = new List<Caja>();

}