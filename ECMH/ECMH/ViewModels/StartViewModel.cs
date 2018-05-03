﻿namespace ECMH.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.ComponentModel;
    using System.Windows.Input;
    using Views;
    using Xamarin.Forms;

    public class StartViewModel : BaseViewModel


    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion



        #region Attributes
        private bool isEnabled;

        #endregion

        #region Constructors
        public StartViewModel()
        {
            this.IsEnabled = true;

        }
        #endregion

        #region Commands
        public ICommand StartCommand
        {
            get
            {
                return new RelayCommand(Start);

            }
            
        }

        

        public async void Start()
        {

            this.IsEnabled = false;

            MainViewModel.GetInstance().Start = new StartViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new MonicoPage());




        }

        #endregion


        #region Properties
        public bool IsEnabled { get; set; }
        
        #endregion

    }
}