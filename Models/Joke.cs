using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesWebApp.Models
{
    public class Joke
    {
        //properties, con prop + tab escribe todo y llenas las cosas
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }  

        //constructor  shortcut ctor
        public Joke()
        {
            
        }

        
    }
}
