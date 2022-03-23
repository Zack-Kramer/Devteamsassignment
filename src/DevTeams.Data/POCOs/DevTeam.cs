using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class DevTeam
    {
       //1st overload, like 'overlord presiding'
       public DevTeam() {}

    public DevTeam(string v)
    {
        V = v;
    }


    //3rd overload, redemption time. Full Constructor = SSJ3.
    public DevTeam(string name, List<Developer> developers)
       {
           Name = name;
           Developers = developers;
           //list of type t, whatever type in between the <> brackets I can use the list methods.

       }
       //^this guy is just for seeding

       //The unique Identifiers

       public int ID { get; set; }
       public string Name {get; set;}
       public List <Developer> Developers { get; set; }
    public string V { get; }
}
