using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunt_the_Wumpus_2025
{
    public class GameControl : IGameControl
    {
        public string BringHomeBacon()
        {
            return "";
        }
    }
    public interface IGameControl
    {
        string BringHomeBacon(); // this brings home the bacon

        void Maxim();
    }
}
