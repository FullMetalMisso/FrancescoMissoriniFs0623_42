namespace esercizioPome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i tuoi dati");
            Console.WriteLine("Nome:");
            string readName = Console.ReadLine();
            Console.WriteLine("Cognome:");
            string readSurname = Console.ReadLine();
            Console.WriteLine("Eta:");
            byte readEta = byte.Parse(Console.ReadLine());

            Persona utente2 = new Persona(readName, readSurname, readEta);
            utente2.GetDettagli();
            Persona utente1 = new Persona("massimo", "meridio", 30);
            Console.WriteLine(utente1.Name+ " " + utente1.Cognome+ " " + utente1.Eta.ToString());
        }
    }
    class Persona
    {

        private string _name;

        private string _cognome;

        private byte _eta;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 0)
                {
                    _name = char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                if (value.Length > 0)
                {
                    _cognome = char.ToUpper(value[0]) + value.Substring(1).ToLower();
                }
            }
        }

        public byte Eta
        {
            get
            {
                return _eta;

            }
            set
            {
                if (value > 0 && value < 140)
                {
                    _eta = value;
                }
            }
        }

        public Persona(string nome, string cognome, byte eta)
        {
            this.Name = nome;
            this.Cognome = cognome;
            this.Eta = eta;

        }

        public void GetDettagli()
        {
            Console.WriteLine("Nome : " + Name + " " + "Cognome: " + Cognome + "Eta : " +Eta+ " ");
        }


    }
}