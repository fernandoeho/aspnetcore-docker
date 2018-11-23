using System;

namespace Greetings.API.Models
{
    public class Greeting
    {
        public Greeting(string name, string machineName, string oS)
        {
            Subject = "Administração de Sistema Operacional em Plataformas Proprietárias";
            Message = String.Format("Olá, {0}", name);
            Name = name;
            MachineName = machineName;
            OS = oS;
            DateTimeStamp = DateTime.Now;
        }

        public string Subject { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public string MachineName { get; set; }
        public string OS { get; set; }
        public DateTime DateTimeStamp { get; set; }
    }
}