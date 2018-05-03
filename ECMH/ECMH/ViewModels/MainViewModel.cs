namespace ECMH.ViewModels
{
    using System.Collections.Generic;
    using ViewModels;

  public  class MainViewModel
    {
       

        #region ViewModels
        public StartViewModel  Start { get; set; }
        public MonicoViewModel Monico { get; set; }

        #endregion


        #region Constructor

        public MainViewModel()
        {
            instance = this;
            this.Start = new StartViewModel();
            // solo se instancia cuando se ocupa
            //this.Monico = new MonicoViewModel();

        }

        #endregion


        #region Singleton

        public static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }


        #endregion
    }
}
