namespace ALM.WeChatAdmin.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_User
    {
        [Key]
        public Guid UserID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserPwd { get; set; }

        [Required]
        [StringLength(32)]
        public string OpenID { get; set; }
    }
}
