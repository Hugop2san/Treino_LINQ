using System;
using System.Globalization;
using treinolinq;

namespace treinolinq
{

    public class Product
    {
       public int Id{get; set;}
       public string Name{get; set;}
       public double Price{get; set;}
       public Category Cat{get; set;}


        public override string ToString()
        {
            return 
            "ID :"+Id+ 
            " - Name :"+Name+ 
            " - Category Name:"+Cat.Name+ 
            " - Category Tier:"+Cat.Tier ;
        }  
    }
}