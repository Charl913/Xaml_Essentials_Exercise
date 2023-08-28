using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private string[] quoteList = new string[]
        {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };
        public QuotesPage()
        {
            InitializeComponent();

            Quote.Text = quoteList[0];


        }

        public int position = 1;

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (position < 3)
            {
                Quote.Text = quoteList[position];
            }
            else
            {
                position = 0;
                Quote.Text = quoteList[position];
            }
            position++;
        }
    }
}