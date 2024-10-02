using ListaTarefas.Enums;
using System.ComponentModel.DataAnnotations;

namespace ListaTarefas.Models;
public class Tarefas
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(80)]
    public string? Titulo { get; set; }

    [Required]
    [StringLength(200)]
    [Display(Name = "Descrição")]
    public string? Descricao { get; set; }

    [Display(Name = "Concluído?")]
    public bool Concluido { get; set; }

    [Display(Name = "Nível de Prioridade")]
    public PrioridadeNivel Prioridade { get; set; }

    [Display(Name = "Data de Cadastro")]
    public DateTime DataCadastro { get; set; }
}
