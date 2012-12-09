using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emina.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string questionText { get; set; }
        public string type { get; set; }
        public virtual Enquete enquete {get; set;}
    }
}