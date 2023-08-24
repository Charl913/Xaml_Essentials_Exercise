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
        public QuotesPage()
        {
            InitializeComponent();

            Quote.Text = "Life is like riding a bicyle. To keep your balance, You must keep moving";
        }

        public int postion = 1;
        private void Button_Clicked(object sender, EventArgs e)
        {
            
            List<string> list = new List<string>();
            list.Add("Life is like riding a bicyle. To keep your balance, You must keep moving");
            list.Add("You can't blame gravity for falling in love");
            list.Add("Look deep into nature, and then you will understand everyhing better");

            if(postion < 3)
            {
                Quote.Text = list[postion];
            }
            else 
            {
                postion = 0;
                Quote.Text = list[postion];
            }

            postion++;

        }
    }
}