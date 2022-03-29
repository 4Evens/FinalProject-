using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int categoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
