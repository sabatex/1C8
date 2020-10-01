using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Description1C8(Name = "КлассыУсловийТрудаПоРезультатамСпециальнойОценки", Comment = "", Synonym = "Классы условий труда по результатам специальной оценки")]
    public enum КлассыУсловийТрудаПоРезультатамСпециальнойОценки
    {
        [Description1C8(Name = "Опасный", Comment = "", Synonym = "Опасный, подкласс условий труда 4")]
        Опасный,
        [Description1C8(Name = "Вредный1", Comment = "", Synonym = "Подкласс 3.1 класса условий труда 'вредный'")]
        Вредный1,
        [Description1C8(Name = "Вредный2", Comment = "", Synonym = "Подкласс 3.2 класса условий труда 'вредный'")]
        Вредный2,
        [Description1C8(Name = "Вредный3", Comment = "", Synonym = "Подкласс 3.3 класса условий труда 'вредный'")]
        Вредный3,
        [Description1C8(Name = "Вредный4", Comment = "", Synonym = "Подкласс 3.4 класса условий труда 'вредный'")]
        Вредный4,
        [Description1C8(Name = "Допустимый", Comment = "", Synonym = "Допустимый, подкласс условий труда 2")]
        Допустимый,
        [Description1C8(Name = "Оптимальный", Comment = "", Synonym = "Оптимальный, подкласс условий труда 1")]
        Оптимальный
    }
}
