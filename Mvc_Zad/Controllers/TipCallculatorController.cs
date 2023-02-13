using Mvc_Zad.Modal;
using Mvc_Zad.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_Zad.Controllers
{
    public class TipCallculatorController
    {
        private Tip tip;
        private Display display;

        public TipCallculatorController()
        {
            display = new Display();
            tip = new Tip(display.Amount, display.Percent);
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            display.ShowTipAndTotal();
        }

    }
}
