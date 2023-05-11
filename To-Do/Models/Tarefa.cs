using System.ComponentModel.DataAnnotations;

namespace To_Do.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(50, ErrorMessage = "Use Menos Caracteres") ]
        public String Nome { get; set; }

        public String Data { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório ")]
        [DataType(DataType.Time)] 
        public String Horario { get; set; }
    }
}
