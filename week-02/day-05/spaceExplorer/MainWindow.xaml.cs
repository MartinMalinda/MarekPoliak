using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Threading;
using GreenFox;
using System;

namespace DrawingApplication
{
    public class Stars
    {
        public Stars(FoxDraw foxDraw)
        {
            foxDraw.SetBackgroundColor(Colors.Black);
            Random random = new Random();
            for (int i = 0; i < stars.Length; i++)
            {
                int ran1 = random.Next(0, 800);
                int ran2 = random.Next(0, 800);
                stars[i] = new Star(ran1, ran2, foxDraw);
            }
        }
        public void MoveStars()
        {
            for (int i = 0; i < stars.Length; i++)
            {

                if (stars[i].lin.StartPoint.X > 800 || stars[i].lin.StartPoint.Y > 800 || stars[i].lin.StartPoint.X < 0 || stars[i].lin.StartPoint.Y < 0)
                {
                    Random random = new Random();
                    int x = random.Next(0, 800);
                    int y = random.Next(0, 800);

                    stars[i].lin.EndPoint = new Point(x, y);
                    stars[i].lin.StartPoint = new Point(x - stars[i].vec[0] / 2, y - stars[i].vec[1] / 2);
                    stars[i].CalculateVec();
                    stars[i].velX = 0.1;
                    stars[i].velY = 0.1;
                }
                stars[i].velX = stars[i].velX + stars[i].vec[0] / 50;
                stars[i].velY = stars[i].velY + stars[i].vec[1] / 50;
                stars[i].lin.StartPoint = new Point(stars[i].lin.StartPoint.X + stars[i].velX * stars[i].trailConstant, stars[i].lin.StartPoint.Y + stars[i].velY * stars[i].trailConstant);
                stars[i].lin.StartPoint = new Point(stars[i].velX + stars[i].lin.StartPoint.X, stars[i].velY + stars[i].lin.StartPoint.Y);
                stars[i].lin.EndPoint = new Point(stars[i].velX + stars[i].lin.EndPoint.X, stars[i].velY + stars[i].lin.EndPoint.Y);
            }
        }
        Star[] stars = new Star[150];
    }

    public class Star
    {
        public Star(int x, int y, FoxDraw foxDraw)
        {

            lin = new Line()
            {
                Stroke = new SolidColorBrush(Colors.White),
                StartPoint = new Point(x, y),
                EndPoint = new Point(x, y),
                StrokeThickness = 1
            };
            CalculateVec();
            foxDraw.Canvas.Children.Add(lin);
        }
        public void CalculateVec()
        {
            vec[0] = lin.StartPoint.X - 400;
            vec[1] = lin.StartPoint.Y - 400;
            double temp = vec[0];
            vec[0] = vec[0] / Math.Sqrt(vec[0] * vec[0] + vec[1] * vec[1]);
            vec[1] = vec[1] / Math.Sqrt(temp * temp + vec[1] * vec[1]);
        }
        public Line lin;
        public double[] vec = new double[2];
        public double trailConstant = 0.02;
        public double velX = 0.1;
        public double velY = 0.1;
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
            canvas.Width = 800;
            canvas.Height = 800;
            Stars stars = new Stars(foxDraw);
            timer = new DispatcherTimer();
            timer.Interval = new System.TimeSpan(0, 0, 0, 0, 30);
            double i = 0;
            timer.Tick += delegate
            {
                OnTick(ref i, ref foxDraw, stars);
            };
            timer.Start();
        }
        public void OnTick(ref double i, ref FoxDraw foxDraw, Stars stars)
        {
            stars.MoveStars();
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
