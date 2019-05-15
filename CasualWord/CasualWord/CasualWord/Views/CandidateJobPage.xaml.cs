using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CasualWord.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CandidateJobPage : ContentPage
	{
        public ObservableCollection<int> testList;
		public CandidateJobPage ()
		{
			InitializeComponent ();
            testList = new ObservableCollection<int>();
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            testList.Add(1);
            listView.ItemsSource = testList;
            MyListView.ItemsSource = testList;
            MyListHistory.ItemsSource = testList;

        }

       async private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new CandidateJobPost());
        }
    }
}