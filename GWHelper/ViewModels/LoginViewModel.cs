using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GWHelper.Commands;
using GWHelper.Infrastructure.Services.Interfaces;
using Autofac;
using GWHelper.Infrastructure.Models;

namespace GWHelper.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _apiKey;
        public string ApiKey
        {
            get => _apiKey;
            set
            {
                _apiKey = value;
                OnPropertyChanged("ApiKey");
            }
        }

        private RelayCommand _createCommand;

        public RelayCommand CreateCommand
        {
            get
            {
                return _createCommand ?? (_createCommand = new RelayCommand(async (obj) =>
                {
                    using (var scope = AutofacContainer.Container.BeginLifetimeScope())
                    {
                        var gwService = scope.Resolve<IGwUserService>();
                        var account = await gwService.GetAccount(_apiKey);

                        if (account == null) return;

                        var dbUserService = scope.Resolve<IDbService<User>>();
                        dbUserService.AddItem(account);
                        AppContext.Instance.ApiKey = account.api_key;
                    }
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
    }
}
