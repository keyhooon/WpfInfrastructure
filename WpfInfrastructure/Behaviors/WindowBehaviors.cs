using System.Diagnostics;
using System.Windows;
using Microsoft.Xaml.Behaviors;

namespace WpfInfrastructure.Behaviors
{
    public class DragMoveBehavior : Behavior<UIElement>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseDown += (sender, args) => Window.GetWindow(AssociatedObject)?.DragMove();
        }
    }
    public class WindowMaximizerBehavior : Behavior<UIElement>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseDown += (sender, args) =>
            {
                if (args.ClickCount == 2)
                {
                    var window = Window.GetWindow(AssociatedObject);
                    Debug.Assert(window != null, nameof(window) + " != null");
                    window.WindowState = window.WindowState == WindowState.Normal
                        ? WindowState.Maximized
                        : WindowState.Normal;
                }
            };
        }
    }
}
