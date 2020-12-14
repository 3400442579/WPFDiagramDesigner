using DiagramDesigner.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;


namespace DiagramDesigner
{
    public class MainViewModel : ViewModelBase
    {
        public ReactiveProperty<Iteml> SelectIteml { get; } = new ReactiveProperty<Iteml>();
        public ReactiveCollection<Iteml> Itemls { get; } = new ReactiveCollection<Iteml>();
        public MainViewModel()
        {
            Itemls.Add(new Iteml { Text = "1zzzzzzz", X = 10, Y = 10, W = 100, H = 30, ZIndex = 3 });
            Itemls.Add(new Iteml { Text = "3zzzzz", X = 50, Y = 50, W = 100, H = 30, ZIndex = 0 });
            Itemls.Add(new Iteml { Text = "2zzzz", X = 10, Y = 100, W = 100, H = 30, ZIndex = 10 });


            SelectIteml.Subscribe(x =>
            {
                if (x != null)
                    System.Diagnostics.Debug.WriteLine(x.X + "," + x.H + "," + "," + x.W + "," + x.H);
            });

        }

    }

    public class Iteml : ViewModelBase
    {
        //text

        private string text;
        public string Text
        {
            get => text;
            set => this.SetProperty(ref text, value);
        }


        private double w;
        public double W
        {
            get => w;
            set => this.SetProperty(ref w, value);
        }

        private double h;
        public double H
        {
            get => h;
            set => this.SetProperty(ref h, value);
        }


        private double x;
        public double X
        {
            get => x;
            set => this.SetProperty(ref x, value);
        }

        private double y;
        public double Y
        {
            get => y;
            set => this.SetProperty(ref y, value);
        }

        public bool IsImg { get; set; } = false;


        private int zIndex;
        public int ZIndex
        {
            get => zIndex;
            set => this.SetProperty(ref zIndex, value);
        }

    }
}
