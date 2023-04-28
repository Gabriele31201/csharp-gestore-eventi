using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        //attributes
        private string Title;
        private string Date;
        private int MaxCapientEvent;
        private int NumberOfSeatBooked;

        //constructor
        public Evento(string Title, string Date, int MaxCapientEvent, int NumberOfSeatBooked) 
        {
            this.Title = Title;
            this.Date = Date;
            this.MaxCapientEvent = MaxCapientEvent;
            this.NumberOfSeatBooked = NumberOfSeatBooked;
        }
    }
}
