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
                    StartPoint = new Point(position.X-50, position.Y-50),
                    EndPoint = new Point(position.X, position.Y),
                    StrokeThickness = 1
                };
                foxDraw.Canvas.Children.Add(lines[i]);
            }
            
            tempSize = size / 2;
        }
        
        public void rotateX(double num,FoxDraw foxDraw)
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

    public class stars
    {
        public stars(FoxDraw foxDraw)
        {
            foxDraw.SetBackgroundColor(Colors.Black);
            Random random = new Random();
            for (int i = 0; i < sts.Length; i++)
            {
                int ran1 = random.Next(0, 800);
                int ran2 = random.Next(0, 800);
                sts[i] = new star(ran1, ran2, foxDraw);
            }
        }
        public void moveStars()
        {
            for (int i = 0; i < sts.Length; i++)
            {
                
                if(sts[i].pos.X>800|| sts[i].pos.Y > 800|| sts[i].pos.X < 0|| sts[i].pos.Y < 0)
                {
                    Random random = new Random();
                    int x = random.Next(0, 800);
                    int y = random.Next(0, 800);
                    sts[i].pos = new Point(x,y);
                    sts[i].lin.EndPoint = new Point(x+1,y+1);
                    sts[i].lin.StartPoint = new Point(x,y);
                    sts[i].calculateVec();
                }
                sts[i].pos = new Point(sts[i].vec[0] * sts[i].velocity*sts[i].distance + sts[i].pos.X, sts[i].vec[1] * sts[i].velocity * sts[i].distance + sts[i].pos.Y);
                sts[i].lin.EndPoint= new Point(sts[i].vec[0]*sts[i].velocity * sts[i].distance + sts[i].lin.EndPoint.X, sts[i].vec[1] * sts[i].velocity * sts[i].distance + sts[i].lin.EndPoint.Y);
                sts[i].lin.StartPoint= new Point(sts[i].vec[0] * sts[i].velocity * sts[i].distance + sts[i].lin.StartPoint.X, sts[i].vec[1] * sts[i].velocity * sts[i].distance + sts[i].lin.StartPoint.Y);
                sts[i].calculateVel();
            }
        }
        star[] sts = new star[100];
    }
       
    public class star
    {
        public star(int x, int y,FoxDraw foxDraw)
        {
            pos = new Point(x, y);

            lin = new Line()
            {
                Stroke = new SolidColorBrush(Colors.White),
                StartPoint = new Point(x+1 , y+1 ),
                EndPoint = new Point(x, y),
                StrokeThickness = 1
            };
            calculateVec();
            calculateVel();
            Random random = new Random();
            distance = random.Next(5, 10)/10.0;
            
            foxDraw.Canvas.Children.Add(lin);
            
            

        }
        public void calculateVec()
        {
            vec[0] = pos.X - 400;
            vec[1] = pos.Y - 400;

            double temp = vec[0];
            vec[0] = vec[0] / Math.Sqrt(vec[0] * vec[0] + vec[1] * vec[1]);
            vec[1] = vec[1] / Math.Sqrt(temp * temp + vec[1] * vec[1]);
        }
        public void calculateVel()
        {
            double temp1 = pos.X - 400;
            double temp2 = pos.Y - 400;
            velocity = Math.Abs(Math.Sqrt(temp1 * temp1 + temp2 * temp2)/400)*2;
            
        }
        public double velocity = 0;
        public double distance = 0;
        public Line lin;
        public Point pos;
        public double[] vec = new double[2];
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
            stars st = new stars(foxDraw);


            timer = new DispatcherTimer();
            timer.Interval = new System.TimeSpan(0, 0, 0, 0, 1);
            double i = 0;
            timer.Tick += delegate
            {
                OnTick(ref i, ref foxDraw,st);
            };
            timer.Start();



        }
        public void OnTick(ref double i, ref FoxDraw foxDraw,stars st)
        {
            st.moveStars();
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
