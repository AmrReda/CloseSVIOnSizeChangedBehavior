using System.Windows;
using System.Windows.Interactivity;
using Microsoft.Surface.Presentation.Controls;

namespace CloseSVIOnSizeChangedBehavior.Behaviors
{
    public class  CloseSVIOnSizeChanged : Behavior<ScatterViewItem>
    {
        public static readonly DependencyProperty MinSizeProperty =
            DependencyProperty.Register("MinSize", typeof (double), typeof (CloseSVIOnSizeChanged), new PropertyMetadata(default(double)));

        public double MinSize
        {
            get { return (double) GetValue(MinSizeProperty); }
            set { SetValue(MinSizeProperty, value); }
        }

        protected override void OnAttached()
        {
            base.OnAttached();

            ScatterViewItem svi = AssociatedObject;
            if (svi != null)
            {
                svi.SizeChanged += svi_SizeChanged;
            }
        }

        void svi_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.NewSize.Width < e.PreviousSize.Width)
            {
                //TODO: Remove it from parent ScatterView
            }
        }
    }
}