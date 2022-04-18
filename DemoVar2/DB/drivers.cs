namespace DemoVar2.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class drivers
    {
        public string Идентификатор { get; set; }

        [Key]
        public string Фамииля { get; set; }

        public string Имя { get; set; }

        public string Отчество { get; set; }

        public string Паспорт { get; set; }

        [Column("Адрес регистрации")]
        public string Адрес_регистрации { get; set; }

        [Column("Адрес проживания")]
        public string Адрес_проживания { get; set; }

        [Column("Место работы")]
        public string Место_работы { get; set; }

        public string Должность { get; set; }

        [Column("Мобильный телефон")]
        public string Мобильный_телефон { get; set; }

        public string Email { get; set; }

        public string Фотография { get; set; }

        public string Замечания { get; set; }
    }
}
