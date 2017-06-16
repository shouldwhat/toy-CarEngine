using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace AboutCarEngine
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeAttribute();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            MovingFinishedManager.INSTANCE.finishMovingEvent += INSTANCE_finishMovingEvent;
            ReDrawingCarManager.INSTANCE.reDrawCarEvent += INSTANCE_reDrawCarEvent;
        }

        private void INSTANCE_reDrawCarEvent()
        {
            this.car.RenderTransform = new RotateTransform(this.car.handle.angle, 15, 15);

            Canvas.SetLeft(this.car, this.car.nowPoint.X);
            Canvas.SetTop(this.car, this.car.nowPoint.Y);
        }

        private void INSTANCE_finishMovingEvent()
        {
            this.timer.Stop();
        }

        private void InitializeAttribute()
        {
            this.timer = new DispatcherTimer();
            this.timer.Interval = TimeSpan.FromMilliseconds(50);
            this.timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.car.drive();
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point clickPoint = e.GetPosition(this);

            this.car.setDestPos(clickPoint);

            if(this.timer.IsEnabled == false)
            {
                this.timer.Start();
            }
        }

        public DispatcherTimer timer { get; private set; }
    }
}
