using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssianRoullete
{
    public class Roulleteclass
    {
        public int loadguns;
        public int winscore = 0;
        public int Shootaweay;
        public int totalbulletsleft = 6;
        public int spin = 0;

        public int Bulleteaway()
        {

            if (loadguns == 1 && totalbulletsleft > 0 && Shootaweay == 2)
            {

                winscore = 1;


            }
            if (loadguns == 1 && totalbulletsleft > 0 && Shootaweay == 1)
            {

                winscore = 2;

            }

            else if (totalbulletsleft > 0 && loadguns != 1)
            {
                winscore = 0;
                totalbulletsleft = totalbulletsleft - 1;
                Shootaweay = Shootaweay - 1;

                if (loadguns == 6)
                {
                    loadguns = 1;
                }
                else
                {
                    loadguns++;
                }



            }
            return winscore;
        }
        public int shootloaded()
        {
            if (totalbulletsleft > 0 && loadguns == 1)
            {

                spin = 1;




            }
            else if (totalbulletsleft > 0 && loadguns != 1)
            {
                spin = 2;

            }
            return spin;
        }
        public int Spinloadedbullete(int lodedbullete)
        {
            if (lodedbullete == 6)
            {
                lodedbullete = 1;
            }
            else
            {
                lodedbullete++;
            }
            return lodedbullete;
        }
    }
}
