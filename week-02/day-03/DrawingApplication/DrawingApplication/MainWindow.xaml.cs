using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Threading;
using GreenFox;
using System;
using System.Reactive.Disposables;
using Avalonia.Skia;
using System.Collections.Generic;
using System.Linq;

namespace DrawingApplication
{
    public class cube
    {
        public cube(int size, int posX, int posY,FoxDraw foxDraw)
        {
            position = new Point(posX, posY);
            this.size = size;
            lines = new Line[4];
            for (int i = 0; i < 4; i++)
            {
                lines[i]= new Line()
                {
                    Stroke = new SolidColorBrush(Colors.Black),
                    StartPoint = new Point(50, 50),
                    EndPoint = new Point(100, 100),
                    StrokeThickness = 1
                };
                foxDraw.Canvas.Children.Add(lines[i]);
            }
            tempSize = size / 2;
        }
        public void rotate(double num,FoxDraw foxDraw)
        {
            for (int i = 0; i < 4; i++)
            {   
                double tem1 = num + 1.57 * i;
                double tem2 = num + 1.57 * (i+1);

                //square.Points[i].Transform(new Matrix(0, 0, 0, 0, position.X + (Math.Sin(tem1)) * tempSize, position.Y + (Math.Cos(tem1)) * tempSize));
                //square.Points[i]= new Point(position.X + (Math.Sin(tem1)) * tempSize, position.Y + (Math.Cos(tem1)) * tempSize);
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
            

            foxDraw.SetFillColor(Colors.Transparent);
            cube drawing = new cube(100, 400, 400, foxDraw);
            timer = new DispatcherTimer();
            timer.Interval = new System.TimeSpan(0, 0, 0, 0, 1);
            double i = 0;
            timer.Tick += delegate
            {
                OnTick(ref i, ref foxDraw,drawing);
            };
            timer.Start();
            



        }
        public void OnTick(ref double i, ref FoxDraw foxDraw,cube drawing)
        {
            drawing.rotate(i,foxDraw);
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


        public static void steps(FoxDraw foxDraw, int count, int size)
        {
            for (int i = 0; i < count; i++)
            {
                foxDraw.DrawRectangle(i * size + sum(i - 1) * 2, i * size + sum(i - 1) * 2, size + i * 2, size + i * 2);
            }
        }
        public static int sum(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static void circleThingy(FoxDraw foxDraw)
        {
            for (int i = 0; i < 5000; i++)
            {
                foxDraw.DrawLine(400, 400, (Math.Sin(i) + 1) * 400, (Math.Cos(i) + 1) * 400);
            }
        }
        public static void cubeDraw(FoxDraw foxDraw, int size, long margin)
        {

            int quarter = size / 4;
            foxDraw.DrawRectangle(quarter + margin, margin, size, size);
            foxDraw.DrawRectangle(margin, quarter + margin, size, size);

            foxDraw.DrawLine(margin, margin + quarter, quarter + margin, margin);
            foxDraw.DrawLine(margin + size, margin + quarter, quarter + margin + size, margin);
            foxDraw.DrawLine(margin, margin + quarter + size, quarter + margin, margin + size);
            foxDraw.DrawLine(margin + size, margin + quarter + size, quarter + margin + size, margin + size);


        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
