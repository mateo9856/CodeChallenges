using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{//https://www.codewars.com/kata/58b1ae711fcffa34090000ea/train/csharp
    public class DoorOpener
    {
        public string ProcessEvents(string events)
        {
            bool pState = false;
            bool openClose = true;//true - open, false - close
            int counter = 0;
            var builder = new StringBuilder();
            foreach (var ev in events)
            {
                switch (ev)
                {
                    case 'P':
                        pState = !pState;
                        openClose = counter == 5 ? false : counter == 0 ? true : openClose;
                        break;
                    case 'O':
                        openClose = !openClose;
                        pState = true;
                        break;
                }
                counter = (openClose == true && pState == true && counter < 5) ? counter+=1 :
                (openClose == false && pState == true && counter > 0) ? counter-=1 : counter;
                if (counter == 5 || counter == 0) pState = false;
                builder.Append(counter.ToString());
            }
            return builder.ToString();
        }
    }
}
