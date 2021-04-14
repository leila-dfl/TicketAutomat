using System;


namespace TicktAutomat
{
    class TicketClass
    {
        private string nameticket;
        private string Beschreibung;
        private int ticketId= 0;
        private double priceticket;
        private double bezahlterBetrag=0;
        private double rect=0;
        public string date;

        public double BezahlterBetrag
        {
            get { return this.bezahlterBetrag; }
            set { this.bezahlterBetrag = value; }
        }

        public double Priceticket(string type)
        {        
            switch (type)
            {
                case "A":
                    nameticket = " 'A' ";
                    priceticket = 2.50;
                    break;
                case "B":
                    nameticket = " 'B' ";
                    priceticket = 3.50;
                    break;
                case "C":
                    nameticket = " 'C' ";
                    priceticket = 4.50;
                    break;
                default:
                    priceticket = 0;
                    break;
            }
            return priceticket;
        }
        public double rectBetrag()
        {
           rect= BezahlterBetrag - priceticket;
            return rect;
        }
         public string showDateundTime()
         {
            DateTime dt = DateTime.Now;
            date = dt.ToString("yyyy-MM-dd , HH-mm-ss");
            return date;   
         }
        public int aufbaTicketId()
        {
            return ticketId += 1;
        }
        public string inhaltBeschribung()
        {
            if (BezahlterBetrag == 0)
            {
                this.Beschreibung = "Das Ticket wurde nicht ausgestellt ";
            }
            else
            {
                aufbaTicketId();
                this.Beschreibung = "Das Ticket wurde ausgestellt ";
            }
            return this.Beschreibung;
        }
        public void printTicket()
        {
            rectBetrag();
            inhaltBeschribung();
            showDateundTime();
            Console.WriteLine("Zeit ist : {0}",date);
            Console.WriteLine("Beschreibung : {0}", Beschreibung);
            Console.WriteLine("Name des Tickets ist  :{0} und seine Nummer ist : {1} ", nameticket,ticketId);
            Console.WriteLine("Bezahlter Betrag is : {0} . priceticket ist {1} deshalb ist rect {2} "
                , BezahlterBetrag, priceticket,rect);
            Console.WriteLine("------------------------------");

        }






    }
}
