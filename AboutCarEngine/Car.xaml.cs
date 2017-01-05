using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static AboutCarEngine.CarNavigator;

namespace AboutCarEngine
{
    /// <summary>
    /// Car.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Car : UserControl
    {
        public Car()
        {
            InitializeComponent();
            InitializeAttributes();
        }

        private void InitializeAttributes()
        {
            this.velocity = 15;
            this.nowPoint = this.destPoint = new Point(0, 0);
            this.engine = new CarEngine();
            this.handle = new CarHandle();
            this.navigator = new CarNavigator();
        }

        public void drive()
        {
            /* [Step.1] 진행 방향(direction) 계산
             * [Step.2] 핸들 각도(angle) 계산
             * [Step.3] Car 속도(velocity) 만큼 위치(nowPoint) 이동
             * [Step.4] Canvas에 Car 다시 그리기
             */
            
            /* [Step.1] */
            DIRECTION direction = navigator.search(this.nowPoint, this.destPoint);

            /* [Step.2] */
            double angle = handle.handle(direction, this.nowPoint, this.destPoint);

            /* [Step.3] */
            this.nowPoint = engine.move(direction, this.velocity, this.nowPoint, this.destPoint);

            /* [Step.4] */
            ReDrawingCarManager.INSTANCE.onReDrawCar();

            if(this.isArrved())
            {
                MovingFinishedManager.INSTANCE.onFinishMoving();
            }
        }

        private bool isArrved()
        {
            return false;
        }

        public CarNavigator navigator { get; private set; }
        public CarEngine engine { get; private set; }
        public CarHandle handle { get; private set; }
        public Point nowPoint { get; private set; }
        public Point destPoint { get; set; }
        public double velocity { get; private set; }

    }
}
