using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlazzShop.Models;
public class Product
{
    [Key]
    [Required(ErrorMessage = "Id é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Título é obrigatório")]
    [MaxLength(150, ErrorMessage = "Título deve ter no máximo 50 caracteres")]
    [MinLength(5, ErrorMessage = "Título deve ter no mínimo 5 caracteres")]
    public string Title { get; set; }


    /*[MaxLength(150, ErrorMessage = "Descrição deve ter no máximo 50 caracteres")]
    [MinLength(5, ErrorMessage = "Descrição deve ter no mínimo 5 caracteres")]
    [Required(ErrorMessage = "Descrição é obrigatório")]
    public string Descricao { get; set; }*/

    [Required(ErrorMessage = "Preço é obrigatório")]
    [DataType(DataType.Currency)]
    [Range(0, 9999, ErrorMessage = "Preço deve estar entre 0 e 9999")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Categoria é obrigatória")]
    [Range(1, 9999, ErrorMessage = "Categoria não é válida")]
    public int CategoryId { get; set; }

    public Category ProductCategory { get; set; } = null!;https://github.com/oimarcella/crud-blazor.git
}