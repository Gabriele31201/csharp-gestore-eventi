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
        private DateTime Date;
        private int MaxCapientEvent;
        private int NumberOfSeatBooked;

        //constructor
        public Evento(string Title, string Date, int MaxCapientEvent) 
        {
            this.Title = Title;
            this.Date = DateTime.Parse(Date);
            this.MaxCapientEvent = MaxCapientEvent;
            NumberOfSeatBooked = 0;
        }

        public Evento(string Title, string Date, int MaxCapientEvent, int AlreadyBookedSeats)
        {
            this.Title = Title;
            this.Date = DateTime.Parse(Date);
            this.MaxCapientEvent = MaxCapientEvent;
           
            if(...)
                    this.NumberOfSeatBooked = AlreadyBookedSeats;
        }

        //getters
        public string GetTItle()
        {
            return this.Title;
        }

        public string GetDate() 
        { 
            return this.Date.ToString("dd/MM/yyyy"); 
        }

        // setters

        // methods
        public void BookSeats(int seatsToBook)
        {
            if (MaxCapientEvent < NumberOfSeatBooked)
                this.NumberOfSeatBooked += seatsToBook;
            else
            {
                Console.WriteLine("Non ci sono posti disponibili");
            }
        }
    }
}
