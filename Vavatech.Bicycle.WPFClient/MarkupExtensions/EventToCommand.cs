using System;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

namespace Vavatech.Bicycle.WPFClient.MarkupExtensions
{
    public class EventToCommand : MarkupExtension
    {
        private string _commandPath;
        private ICommand _command;
        private Type _eventArgsType;

        public EventToCommand(string commandPath)
        {
            _commandPath = commandPath;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            Delegate customDelegate = null;
            IProvideValueTarget target = serviceProvider.GetService(typeof(IProvideValueTarget)) as IProvideValueTarget;
            if (target != null)
            {
                EventInfo eventInfo = target.TargetProperty as EventInfo;
                MethodInfo methodInfo = GetType().GetMethod("InvokeCommand", BindingFlags.NonPublic | BindingFlags.Instance);
                Type parameterType = null;
                if (eventInfo != null)
                    parameterType = eventInfo.EventHandlerType;

                if (parameterType != null)
                {
                    _eventArgsType = parameterType.GetMethod("Invoke").GetParameters()[1].ParameterType;
                    customDelegate = Delegate.CreateDelegate(parameterType, this, methodInfo);
                }
            }
            return customDelegate;
        }
        private void InvokeCommand(object sender, RoutedEventArgs e)
        {
            var dataContext = (sender as FrameworkElement).DataContext;
            if (_commandPath != null)
            {
                _command = (ICommand)ParseCommandPath(dataContext, _commandPath);
            }
            var cmdParams = Activator.CreateInstance(_eventArgsType);
            if (_command != null && _command.CanExecute(cmdParams))
                _command.Execute(cmdParams);
        }
        private Object ParseCommandPath(object target, string commandPath)
        {
            return target.GetType().GetProperty(commandPath).GetValue(target);
        }
    }
}
