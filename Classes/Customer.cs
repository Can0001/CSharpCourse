using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
     class Customer// Bir Müşterinin özelliklerini tutmak için kullanıdığımız nesnedir.
    {
        //Field
        //public string FirstName;
        
        //Property
        public int Id { get; set; }
        //string _firstname;
        //public string FirstName { 
        //    get { return "Mrs." +  _firstname; } 
        //    set { _firstname = value; }  
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
