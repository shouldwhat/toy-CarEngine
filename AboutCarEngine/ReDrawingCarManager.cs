using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCarEngine
{
    public delegate void ReDrawCar();
    public class ReDrawingCarManager
    {
        public static ReDrawingCarManager INSTANCE = null;
        public event ReDrawCar reDrawCarEvent = null;

        static ReDrawingCarManager()
        {
            if(INSTANCE == null)
            {
                INSTANCE = new ReDrawingCarManager();
            }
        }
        public void onReDrawCar()
        {
            if(reDrawCarEvent != null)
            {
                /* MainWindow Callback. */
                reDrawCarEvent();
            }
        }
    }
}
