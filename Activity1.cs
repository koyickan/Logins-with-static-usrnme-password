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
using System.Threading.Tasks;

namespace Test1
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {


        protected override void OnCreate(Bundle savedInstanceState)


        {
            base.OnCreate(savedInstanceState)}
        //Bundle.savedInstanceState = "null";
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout1);
            Button login = FindViewById<Button>(Resource.Id.login);

            login.Click += (object sender, EventArgs e) => {
                Android.Widget.Toast.MakeText(this, "Login Button Clicked!", Android.Widget.ToastLength.Short).Show();



                private void SimulateStartup()
                {
                    throw new NotImplementedException();
                }
            
            }
    }
}
}

   
  