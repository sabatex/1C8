using System;
using System.ComponentModel.DataAnnotations;

namespace Sabatex.V1C8.Models;

public class EnumItem
{
    [Key]
    public string Name { get; set; }
    public string Synonym { get; set; }
    public string Comment { get; set; }

}