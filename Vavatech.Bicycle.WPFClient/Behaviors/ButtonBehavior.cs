using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Media;

namespace Vavatech.Bicycle.WPFClient.Behaviors
{
    public class ButtonBehavior : Behavior<Button>
    {
        public string Color
        {
            get { return (string)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Color.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", typeof(string), typeof(ButtonBehavior), new PropertyMetadata("Red"));





        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Command.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(ButtonBehavior), new PropertyMetadata(null));




        protected override void OnAttached()
        {
            var button = this.AssociatedObject;

            button.MouseEnter += Button_MouseEnter;
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var button = sender as Button;

            var color = (Color) ColorConverter.ConvertFromString(this.Color);

            button.Background = new SolidColorBrush(color);

            if (Command.CanExecute(null))
            {
                Command.Execute(null);
            }
        }

    }
}
