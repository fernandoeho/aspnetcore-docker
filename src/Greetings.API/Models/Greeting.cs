using System;

namespace Greetings.API.Models
{
    public class Greeting
    {
        public Greeting(string name, string machineName, string oS)
        {
            Message = String.Format("Olá, {0}", name);
            Name = name;
            MachineName = machineName;
            OS = oS;
            DateTimeStamp = DateTime.Now;
        }

        public string Message { get; set; }
        public string Name { get; set; }
        public string MachineName { get; set; }
        public string OS { get; set; }
        public DateTime DateTimeStamp { get; set; }
    }
}