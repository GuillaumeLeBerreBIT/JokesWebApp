namespace JokesWebApp.Models
{
    public class Joke
    {
        // Creating a property accesability
        public int Id { get; set; } 
        public String JokeQuestion { get; set; }    
        public String JokeAnswer { get; set; }
        
        // Creating a constructor function
        public Joke()
        {
            
        }
    }
}
