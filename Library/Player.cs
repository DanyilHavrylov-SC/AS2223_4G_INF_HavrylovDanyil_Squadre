using System.ComponentModel.DataAnnotations;

namespace Library
{
    public class Player
    {
        string name;
        string surname;
        ERole role;

        public enum ERole 
        { 
            Rosa,
            Riserva
        }
        public Player(string name, string surname, ERole role)
        {
            // TODO P.1
            this.name = name;
            this.surname = surname;
            this.role = role;
        }

        public string Description()
        {
            // TODO P.2
            return $"{surname} {name} {role}";
        }

        public ERole Role { 
            // TODO P.3
        }

    }
}