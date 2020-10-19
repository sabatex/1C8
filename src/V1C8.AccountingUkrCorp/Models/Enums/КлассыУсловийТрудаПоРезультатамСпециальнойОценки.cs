using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using sabatex.V1C8.ComponentModel.DataAnnotations;
using sabatex.V1C8.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace sabatex.V1C8.AccountingUkrCorp.Models.Enums
{
    [Table("KlassyUslovyiTrudaPoRezultatamSpetsyalnoiOtsenky")]
    [Description1C8(Name = "КлассыУсловийТрудаПоРезультатамСпециальнойОценки", Comment = "", Synonym = "Классы условий труда по результатам специальной оценки")]
    public class КлассыУсловийТрудаПоРезультатамСпециальнойОценки:EnumItem
    {
        public static readonly КлассыУсловийТрудаПоРезультатамСпециальнойОценки Опасный = new КлассыУсловийТрудаПоРезультатамСпециальнойОценки{Name= "Опасный",Synonym="Опасный, подкласс условий труда 4",Comment=""};
        public static readonly КлассыУсловийТрудаПоРезультатамСпециальнойОценки Вредный1 = new КлассыУсловийТрудаПоРезультатамСпециальнойОценки{Name= "Вредный1",Synonym="Подкласс 3.1 класса условий труда 'вредный'",Comment=""};
        public static readonly КлассыУсловийТрудаПоРезультатамСпециальнойОценки Вредный2 = new КлассыУсловийТрудаПоРезультатамСпециальнойОценки{Name= "Вредный2",Synonym="Подкласс 3.2 класса условий труда 'вредный'",Comment=""};
        public static readonly КлассыУсловийТрудаПоРезультатамСпециальнойОценки Вредный3 = new КлассыУсловийТрудаПоРезультатамСпециальнойОценки{Name= "Вредный3",Synonym="Подкласс 3.3 класса условий труда 'вредный'",Comment=""};
        public static readonly КлассыУсловийТрудаПоРезультатамСпециальнойОценки Вредный4 = new КлассыУсловийТрудаПоРезультатамСпециальнойОценки{Name= "Вредный4",Synonym="Подкласс 3.4 класса условий труда 'вредный'",Comment=""};
        public static readonly КлассыУсловийТрудаПоРезультатамСпециальнойОценки Допустимый = new КлассыУсловийТрудаПоРезультатамСпециальнойОценки{Name= "Допустимый",Synonym="Допустимый, подкласс условий труда 2",Comment=""};
        public static readonly КлассыУсловийТрудаПоРезультатамСпециальнойОценки Оптимальный = new КлассыУсловийТрудаПоРезультатамСпециальнойОценки{Name= "Оптимальный",Synonym="Оптимальный, подкласс условий труда 1",Comment=""};
    }
}
