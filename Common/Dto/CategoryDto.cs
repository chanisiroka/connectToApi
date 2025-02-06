using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[]? Image { get; set; }

        public IFormFile? ImageFile { get; set; }
        //public virtual ICollection< Product> Products { get; set;}
    }
}
