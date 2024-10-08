using MyfistMVC.Models;
using MyfistMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfistMVC.Controllers
{
    public class TipController
    {
        Display myDisp = new Display();
        Tip myTip = new Tip();
        public TipController() 
        {
            myDisp.Input();

            myTip.Amount = myDisp.Amount;
            myTip.Percent = myDisp.Percent;

            myDisp.TipSum = myTip.CalculateTip();
            myDisp.TotalSum = myTip.CalculateTotal();

            myDisp.Output();
        }
    }
}
