using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Developer
    {
     //ctor (like 'kotor' but you're a Sith Hipster.)
     public Developer(){}

    //Also the syntax ^^ above is meant to be 'inputs' (if that's wrong, I know, but it makes sense to thevocabulary in which my brain is resonating it.)

     public Developer(string firstName, string lastName)
     {
         FirstName = firstName;
         LastName = lastName;
     }   

     //properties: just, Just, JUST describes the DEVELOPER, like a damn narcissist GAH-LEE.
     public int ID { get; set; }
     public string FirstName {get; set;}
     public string LastName { get; set;}

    }