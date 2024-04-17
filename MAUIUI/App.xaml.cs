using System.ComponentModel;
 
namespace MAUIUI
{
    public partial class App : Application
    {
        public App()
        {
 
             

            Current.UserAppTheme = AppTheme.Light;
            InitializeComponent();

            MainPage = new AppShell();

            

        }

        protected override void OnStart()
        {
            base.OnStart();

            BindingContext = new MyViewModel(DeviceDisplay.Current.MainDisplayInfo);
        }
        public class MyViewModel : INotifyPropertyChanged
        {
            private int _microText;
            private int _smallText;
            private int _middleText;
            private int _largeText;
            private int _xlText;
            private int _megaText;
            private int _elasticLargeText;
            private int _elasticMiddleText;

            private int _microEntryHeight;
            private int _middleEntryHeight;

            private int _smallSpacing;
            private int _middleSpacing;
            private int _largeSpacing;

            private int _smallPadding;
            private int _middlePadding;
            private int _largePadding;

            private Thickness _smallMarginLeft;
            private Thickness _middleMarginLeft;
            private Thickness _largeMarginLeft;

            private DateTime _todayDate;

            public int MicroText
            {
                get
                {
                    return _microText;
                }
                set
                {
                    _microText = value;
                    OnPropertyChanged(nameof(MicroText));
                }

            }
            public int SmallText
            {
                get
                {
                    return _smallText;
                }
                set
                {
                    _smallText = value;
                    OnPropertyChanged(nameof(SmallText));
                }

            }
            public int MiddleText
            {
                get
                {
                    return _middleText;
                }
                set
                {
                    _middleText = value;
                    OnPropertyChanged(nameof(MiddleText));
                }

            }
            public int LargeText
            {
                get
                {
                    return _largeText;
                }
                set
                {
                    _largeText = value;
                    OnPropertyChanged(nameof(LargeText));
                }

            }
            public int XLText
            {
                get
                {
                    return _xlText;
                }
                set
                {
                    _xlText = value;
                    OnPropertyChanged(nameof(XLText));
                }

            }
            public int MegaText
            {
                get
                {
                    return _megaText;
                }
                set
                {
                    _megaText = value;
                    OnPropertyChanged(nameof(MegaText));
                }

            }
            public int ElasticLargeText
            {
                get
                {
                    return _elasticLargeText;
                }
                set
                {
                    _elasticLargeText = value;
                    OnPropertyChanged(nameof(ElasticLargeText));
                }

            
            }
            public int ElasticMiddleText
            {
                get
                {
                    return _elasticMiddleText;
                }
                set
                {
                    _elasticMiddleText = value;
                    OnPropertyChanged(nameof(ElasticMiddleText));
                }

            }
            public int MicroEntryHeight
            {
                get
                {
                    return _microEntryHeight;
                }
                set
                {
                    _microEntryHeight = value;
                    OnPropertyChanged(nameof(MicroEntryHeight));
                }

            }
            public int MiddleEntryHeight
            {
                get
                {
                    return _middleEntryHeight;
                }
                set
                {
                    _middleEntryHeight = value;
                    OnPropertyChanged(nameof(MiddleEntryHeight));
                }

            }
            public int SmallSpacing
            {
                get
                {
                    return _smallSpacing;
                }
                set
                {
                    _smallSpacing = value;
                    OnPropertyChanged(nameof(SmallSpacing));
                }

            }
            public int MiddleSpacing
            {
                get
                {
                    return _middleSpacing;
                }
                set
                {
                    _middleSpacing = value;
                    OnPropertyChanged(nameof(MiddleSpacing));
                }

            }
            public int LargeSpacing
            {
                get
                {
                    return _largeSpacing;
                }
                set
                {
                    _largeSpacing = value;
                    OnPropertyChanged(nameof(LargeSpacing));
                }

            }
            public int SmallPadding
            {
                get
                {
                    return _smallPadding;
                }
                set
                {
                    _smallPadding = value;
                    OnPropertyChanged(nameof(SmallPadding));
                }

            }
            public int MiddlePadding
            {
                get
                {
                    return _middlePadding;
                }
                set
                {
                    _middlePadding = value;
                    OnPropertyChanged(nameof(MiddlePadding));
                }

            }
            public int LargePadding
            {
                get
                {
                    return _largePadding;
                }
                set
                {
                    _largePadding = value;
                    OnPropertyChanged(nameof(LargePadding));
                }

            }
            public Thickness SmallMarginLeft
            {
                get
                {
                    return _smallMarginLeft;
                }
                set
                {
                    _smallMarginLeft = value;
                    OnPropertyChanged(nameof(SmallMarginLeft));
                }

            }
            public Thickness MiddleMarginLeft
            {
                get
                {
                    return _middleMarginLeft;
                }
                set
                {
                    _middleMarginLeft = value;
                    OnPropertyChanged(nameof(MiddleMarginLeft));
                }

            }
            public Thickness LargeMarginLeft
            {
                get
                {
                    return _largeMarginLeft;
                }
                set
                {
                    _largeMarginLeft = value;
                    OnPropertyChanged(nameof(LargeMarginLeft));
                }

            }
            public DateTime TodayDate
            {
                get
                {
                    return _todayDate;
                }
                set
                {
                    _todayDate = value;
                    OnPropertyChanged(nameof(TodayDate));
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            }

            public MyViewModel(DisplayInfo screen)
            {
                SetView(screen);

            }

            private void SetView(DisplayInfo screen)
            {
                if(screen.Width < 1400)
                {
                    MicroText = 12;
                    SmallText = 14;
                    MiddleText = 16;
                    LargeText = 18;
                    XLText = 20;
                    MegaText = 22;

                    SmallSpacing = 1;
                    MiddleSpacing = 3;
                    LargeSpacing = 6;

                    SmallPadding = 1;
                    MiddlePadding = 3;
                    LargePadding = 5;

                    SmallMarginLeft = new Thickness(3, 0, 0, 0);
                    MiddleMarginLeft = new Thickness(15, 0, 0, 0);
                    LargeMarginLeft = new Thickness(30, 0, 0, 0);
                }
                else if(screen.Width >= 1400 && screen.Width < 2000)
                {
                    MicroText = 14;
                    SmallText = 16;
                    MiddleText = 18;
                    LargeText = 20;
                    XLText = 22;
                    MegaText = 24;

                    SmallSpacing = 5;
                    MiddleSpacing = 10;
                    LargeSpacing = 20;

                    SmallPadding = 3;
                    MiddlePadding = 5;
                    LargePadding = 10;

                    SmallMarginLeft = new Thickness(10, 0, 0, 0);
                    MiddleMarginLeft = new Thickness(50, 0, 0, 0);
                    LargeMarginLeft = new Thickness(100, 0, 0, 0);
                }
                else
                {
                    MicroText = 16;
                    SmallText = 18;
                    MiddleText = 20;
                    LargeText = 22;
                    XLText = 24;
                    MegaText = 26;

                    SmallSpacing = 8;
                    MiddleSpacing = 15;
                    LargeSpacing = 30;

                    SmallPadding = 5;
                    MiddlePadding = 10;
                    LargePadding = 20;

                    SmallMarginLeft = new Thickness(15, 0, 0, 0);
                    MiddleMarginLeft = new Thickness(75, 0, 0, 0);
                    LargeMarginLeft = new Thickness(150, 0, 0, 0);
                }
                ElasticLargeText = Convert.ToInt32(screen.Height / 45);
                ElasticMiddleText = Convert.ToInt32(screen.Height / 60);

                MicroEntryHeight = Convert.ToInt32(MicroText * 2.5);
                MiddleEntryHeight = Convert.ToInt32(MiddleText * 2.5);

                TodayDate = DateTime.Today;
            }
        }
    }
}
