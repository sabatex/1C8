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
    [Table("KodyOperatsyiOzhydaemyiYPodtverzhdennyiNDSProdazh")]
    [Description1C8(Name = "КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж", Comment = "", Synonym = "Коды операций регистра Ожидаемый и подтвержденный НДС продаж")]
    public class КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж:EnumItem
    {
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж ОжидаемыйНДС = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "ОжидаемыйНДС",Synonym="Ожидаемый НДС",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж ПодтвержденныйНДС = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "ПодтвержденныйНДС",Synonym="Подтвержденный НДС",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "КорректировкаОжидаемогоНДСПоВидамДеятельностиОплат",Synonym="Корректировка ожидаемого НДС по видам деятельности оплат",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж РегистрацияАвансов = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "РегистрацияАвансов",Synonym="Регистрация авансов",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж ОтменаРегистрацииАвансов = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "ОтменаРегистрацииАвансов",Synonym="Отмена регистрации авансов",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж КорректировкаНеправильноОформленныхНалоговыхДокументов = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "КорректировкаНеправильноОформленныхНалоговыхДокументов",Synonym="Корректировка неправильно оформленных налоговых документов",Comment=""};
        public static readonly КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж ПереводОФвСоставНепроизводственных = new КодыОперацийОжидаемыйИПодтвержденныйНДСПродаж{Name= "ПереводОФвСоставНепроизводственных",Synonym="Перевод основных фондов в состав непроизводственных",Comment=""};
    }
}
