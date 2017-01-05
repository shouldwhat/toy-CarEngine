using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCarEngine
{
    public delegate void FinishMoving();
    public class MovingFinishedManager
    {
        public static MovingFinishedManager INSTANCE = null;
        public event FinishMoving finishMovingEvent = null;

        static MovingFinishedManager()
        {
            if(INSTANCE == null)
            {
                INSTANCE = new MovingFinishedManager();
            }
        }

        public void onFinishMoving()
        {
            if(finishMovingEvent != null)
            {
                /* MainWindow Callback. */
                finishMovingEvent();
            }
        }
    }
}
