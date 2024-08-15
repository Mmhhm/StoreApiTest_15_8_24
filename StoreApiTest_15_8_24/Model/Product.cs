using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApiTest_15_8_24.Model
{

        //Make your class public, since by default it is internal.
        public class Store
        {
            //Define the constructor of your PokeItem which is the same name as class, and is not returning anything.
            //Will take a string name, and url as a argument.
            public Store(string name, string url)
            {
                Name = name;
            }
            //Your Properties are auto-implemented.
            public string Name { get; set; }
        }
}
