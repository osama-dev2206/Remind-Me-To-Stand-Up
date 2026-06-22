using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remind_Me_To_Stand_Up
{
    public interface ICore
    {
         int Min { get; }
         int Sec { get;  }

        void UpdateMin();

        void UpdateSec();

        void RestSec();

        void RestMin();
    }


    public class Core : ICore
    {
        public int Min { get; private set; }
        public  int Sec { get; private set; }

        public Core()
        {
            Min = 0;
            Sec = 0;
        }

        public void UpdateMin()
        {
            // min less than 60 then increment it 
            if (this.Min < 59) this.Min++;
            else this.Min=0; // rest min to zero again 
        }

        public void UpdateSec()
        {
            if (this.Sec < 59) this.Sec++;
            else this.Sec = 0;
        }

        public void RestSec()
        {
            this.Sec = 0;
        }

        public void RestMin()
        {
            this.Min = 0;
        }

    }
}
