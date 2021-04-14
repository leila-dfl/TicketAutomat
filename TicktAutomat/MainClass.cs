using System;

namespace TicktAutomat
{
    class MainClass
    {
        static void Main(string[] args)
        {
            TicketClass newTicket = new TicketClass();
            newTicket.Priceticket("B");
            newTicket.BezahlterBetrag = 5.00;
            newTicket.printTicket();
            newTicket.Priceticket("C");
            newTicket.BezahlterBetrag = 6.00;
            newTicket.printTicket();
        }
    }
}
