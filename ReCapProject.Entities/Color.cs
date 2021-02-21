using System;
using ReCapProject.Core.Entities;

namespace ReCapProject.Entities
{
    public class Color:IEntity
    {
      
        public int ID { get; set ; }
        public string ColorName { get; set; }
    }
}
