using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad_2.Modal;
using Zad_2.View;

namespace Zad_2.Controller
{
    public class BusActionController
    {
        private Display display;
        private Transport transport;
        public BusActionController()
        {
            display = new Display();
            transport = new Transport(display.Km, display.Time);
            display.TotalPrice = transport.Calculateprice();
            display.ShowPrice();
        }
    }
}
