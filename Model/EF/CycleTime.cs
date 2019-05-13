namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CycleTime")]
    public partial class CycleTime
    {
        [StringLength(50)]
        public string ID { get; set; }

        public double? RealTimeCycleTime { get; set; }

        public double? AverageTimeCycleTime { get; set; }
    }
}
