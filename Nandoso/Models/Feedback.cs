using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nandoso.Models
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int PersonID { get; set; }
        public string Comment { get; set; }

        [JsonIgnore]
        public virtual Person Person { get; set; }
    }
}