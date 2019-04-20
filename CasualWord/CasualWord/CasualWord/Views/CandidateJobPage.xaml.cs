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
	public partial class CandidateJobPage : ContentPage
	{
        public List<int> testList;
		public CandidateJobPage ()
		{
			InitializeComponent ();
            testList = new List<int>();
            testList.Add(1);
            testList.Add(1);
            listView.ItemsSource = testList;

        }
	}
}