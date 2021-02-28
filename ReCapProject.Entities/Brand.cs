using ReCapProject.Core.Entities;
using System;


namespace ReCapProject.Entities
{
    public class Brand : IEntity
    {
        public int ID { get ; set ; }
        public string BrandName { get; set; }
       
    }
}
