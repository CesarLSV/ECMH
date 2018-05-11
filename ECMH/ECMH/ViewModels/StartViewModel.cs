namespace ECMH.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.ComponentModel;
    using System.Windows.Input;
    using Views;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;


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


        //void OnImageNameTapped(object sender, EventArgs args)
        //{
        //    try
        //    {
                

        //        //    MainViewModel.GetInstance().Start = new StartViewModel();
        //        //await Application.Current.MainPage.Navigation.PushAsync(new MonicoPage());

        //        //Code to execute on tapped event
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}



    }
}
