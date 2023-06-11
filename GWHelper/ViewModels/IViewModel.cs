using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GWHelper.ViewModels
{
    public interface IViewModel : INotifyPropertyChanged
    {
    bool Initialized { get; set; }
    void Load(FrameworkElement element);
    void Unload(FrameworkElement element);
    }
}
