using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Model.Model
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }= DateTime.Now;
        public DateTime ModifiedDate { get; set; }
    }
}
