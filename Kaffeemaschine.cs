using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeemaschine
{
    class Kaffeemaschine
    {       
        double _wasser = 0;
        double _bohnen = 0;
        double _kaffeemenge = 0;
        public double Wasser;
        public double Bohnen;
        public double Kaffeemenge;
        static double _maxWasser = 2.5;
        static double _maxBohnen = 2.5;
        public Kaffeemaschine()
        {           
            Wasser = _wasser;
            Bohnen = _bohnen;
            Kaffeemenge = _kaffeemenge;
        }
        public double wasserAuffüllen(double menge)
        {
            if(menge > _maxWasser)
            {
                Console.WriteLine("Zu viel!");
            }
            else
            {
                _wasser += menge;
            }
            return _wasser;
        }
        public double bohnenAuffüllen(double menge)
        {
            if (menge > _maxBohnen)
            {
                Console.WriteLine("Zu viel!");
            }
            else
            {
                _bohnen += menge;                
            }
            return _bohnen;
        }
        public bool macheKaffee(double menge, double verhaeltnisWasserBohnen)
        {
            if(verhaeltnisWasserBohnen == 1)
            {                
                if(_wasser-menge>0 && _bohnen-menge>0)
                {
                    _wasser -= menge;
                    _bohnen -= menge;
                    _kaffeemenge++;
                    return true;
                }
            }
            if (verhaeltnisWasserBohnen == 2)
            {
                if (_wasser - menge > 0 && _bohnen - menge/2 > 0)
                {
                    _wasser -= menge;
                    _bohnen -= menge/2;
                    _kaffeemenge++;
                    return true;
                }
            }
            if (verhaeltnisWasserBohnen == 0.5)
            {
                if (_wasser - menge > 0 && _bohnen - menge*2 > 0)
                {
                    _wasser -= menge;
                    _bohnen -= menge*2;
                    _kaffeemenge++;                   
                    return true;
                }
            }
            return false;
        }
    }
}
