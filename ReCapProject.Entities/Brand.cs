using System;
using ReCapProject.Core.Entities;

namespace ReCapProject.Entities
{
    public class Brand : IEntity
    {
        public int ID { get ; set ; }
        public string BrandName { get; set; }
       
    }
}
