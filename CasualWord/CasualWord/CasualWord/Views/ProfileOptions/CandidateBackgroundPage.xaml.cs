using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CasualWord.Views.ProfileOptions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CandidateBackgroundPage : ContentPage
    {
        public ObservableCollection<int> testList;
        public CandidateBackgroundPage ()
        {
        InitializeComponent ();
            testList = new ObservableCollection<int>();
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            listView.ItemsSource = testList;
        }
	}
}