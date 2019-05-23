using CasualWord.Views.ProfileOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CasualWord.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CandidateProfilePage : ContentPage
    {
        public CandidateProfilePage()
        {
            InitializeComponent();
        }

        async private void Personal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CandidatePersonalPage());
        }

        async private void Professional_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CandidateProfessionalPage());
        }

        async private void Feedback_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CandidateFeedbacksPage());
        }

        async private void Background_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CandidateBackgroundPage());
        }
    }
}