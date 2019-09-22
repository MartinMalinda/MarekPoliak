using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Threading;
using GreenFox;
using System;
//this code works only if u set canvas public in FoxDraw.cs

namespace DrawingApplication
{
    public class Square
    {
        public Square(int size, int posX, int posY,FoxDraw foxDraw)
        {
            position = new Point(posX, posY);
            this.size = size;
            lines = new Line[4];
            for (int i = 0; i < 4; i++)
            {
                lines[i]= new Line()
                {
                    Stroke = new SolidColorBrush(Colors.Black),
                    StartPoint = new Point(position.X-50, position.Y-50),
                    EndPoint = new Point(position.X, position.Y),
                    StrokeThickness = 1
                };
                foxDraw.Canvas.Children.Add(lines[i]);
            }
            tempSize = size / 2;
        }
        
        public void Rotate(double num,FoxDraw foxDraw)
        {
            for (int i = 0; i < 4; i++)
            {   
                double tem1 = num + 1.57 * i;
                double tem2 = num + 1.57 * (i+1);
                lines[i].StartPoint = new Point(position.X + (Math.Sin(tem1)) * tempSize, position.Y + (Math.Cos(tem1)) * tempSize);
                lines[i].EndPoint = new Point(position.X + (Math.Sin(tem2)) * tempSize, position.Y + (Math.Cos(tem2)) * tempSize);
            }
        }
        public Line[] lines;
        public Point position;
        int size;
        int tempSize;      
    }

    public class MainWindow : Window
    {

        public DispatcherTimer timer;
        public MainWindow()
        {

            InitializeComponent();
#if DEBUG
            this.AttachDevTools();

#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            Square square = new Square(100, 400, 400, foxDraw);
            timer = new DispatcherTimer();
            timer.Interval = new System.TimeSpan(0, 0, 0, 0, 30);
            double i = 0;
            timer.Tick += delegate
            {
                OnTick(ref i, ref foxDraw,square);
            };
            timer.Start();
        }
        public void OnTick(ref double i, ref FoxDraw foxDraw,Square square)
        {
            square.Rotate(i, foxDraw);
            i += 0.01;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        ~MainWindow()
        {
            timer.Stop();
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
