using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1_try.Models
{
    public class BookPart : ContentPart
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int ISBN { get; set; }
        public string Description { get; set; }

    }
}
