using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YuGiOh
{
    using YuGiOh.Interfaces;

    public class YuGiOhGame: IYuGiOhGame
    {

        public void Start()
        {
            throw new NotImplementedException();
        }

        public int FirstPlayerTotalPoints
        {
            get { throw new NotImplementedException(); }
        }

        public int SecondPlayerTotalPoints
        {
            get { throw new NotImplementedException(); }
        }

        public int RoundsPlayed
        {
            get { throw new NotImplementedException(); }
        }
    }
}
