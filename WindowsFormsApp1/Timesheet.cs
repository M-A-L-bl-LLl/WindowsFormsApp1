namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Timesheet")]
    public partial class Timesheet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TimesheetID { get; set; }

        public int StaffID { get; set; }

        public DateTime? Start_DateTime { get; set; }

        public DateTime? End_DateTime { get; set; }

        public decimal? PayAmount { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
