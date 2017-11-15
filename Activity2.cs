using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Test1
{
    [Activity(Label = "Activity2")]
    public class Activity2 : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.layout2);

            // private void SearchTermEntered(object sender, System.Windows.Input.TextCompositionEventArgs e)
            {

                int pay= FindViewById<EditText>(Resource.Id.mnthPay);
                

            }

        }
    }
}