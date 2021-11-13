using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dess_Shop_Repository.POCOs
{
    public enum Brand  //this is my enum allows me to choose a brand
    {
        Gia_Borghini = 1, //it starts a 1
        Ralph_Lauren,
        Nike,
        GUCCI
    }
    public class Shirt //this is our shirt object (P.O.C.O)
    {
        //this is my empty constructor
        public Shirt() 
        {
        } 
        //this is my full constructor
        public Shirt(string name, decimal price, Brand brand )
        {
            //we assign the passed in values to the properties
            Name = name; 
            Price = price;
            Brand = brand;
        }

        //unique identifier
        public int ID { get; set; }  //this is a property
        public string Name { get; set; }  //this is a property
        public decimal Price { get; set; } //this is a property
        public Brand Brand { get; set; } //this is a property

    }
}
