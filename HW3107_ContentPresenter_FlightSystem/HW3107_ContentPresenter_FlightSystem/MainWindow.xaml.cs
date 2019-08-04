using FlightsSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW3107_ContentPresenter_FlightSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Flight flight { get; set; }

        static ILoginToken IloginAnonymous = FlyingCenterSystem.GetFlyingCenterSystemInstance().Login("NoMatch", "1111");
        //actually we send null in this case which is why we get anonymousUseFacade in return.
        AnonymousUserFacade anonymousUserFacade = (AnonymousUserFacade)FlyingCenterSystem.GetFlyingCenterSystemInstance().GetFacade(IloginAnonymous);

        public MainWindow()
        {
            InitializeComponent();

            flight = anonymousUserFacade.GetFlightByID(40092);
            this.DataContext = this;
        }

    }
}
