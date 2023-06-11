using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using GWHelper.Commands;
using GWHelper.Infrastructure.Models;
using GWHelper.Infrastructure.Services.Interfaces;
using GWHelper.Windows;

namespace GWHelper.ViewModels
{
    public class MainWindowViewModel : IViewModel
    {

        private RelayCommand _loginCommand;

        public RelayCommand LoginCommand
        {
            get
            {
                return _loginCommand ?? (_loginCommand = new RelayCommand(async (obj) =>
                {
                    new LoginWindow().Show();
                }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public bool Initialized { get; set; }
        public void Load(FrameworkElement element)
        {
            using (var scope = AutofacContainer.Container.BeginLifetimeScope())
            {
                var dbService = scope.Resolve<IDbService<User>>();
                var lastUser = dbService.FirstOrDefault();

                if (lastUser != null)
                    AppContext.Instance.ApiKey = lastUser.api_key;
            }
        }

        public void Unload(FrameworkElement element)
        {
        }
    }
}
