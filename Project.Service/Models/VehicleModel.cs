namespace Project.Service
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleModel")]
    public partial class VehicleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDmodel { get; set; }

        public int makeID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Abrv { get; set; }

        public virtual VehicleMake VehicleMake { get; set; }
    }
}
