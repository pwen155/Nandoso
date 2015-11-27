using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nandoso.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}