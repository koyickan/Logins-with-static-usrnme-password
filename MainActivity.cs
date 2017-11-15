using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Android.Content;
using static Android.Bluetooth.BluetoothClass;
using System;

namespace Test1

{
   

    [Activity(Label = "Test1", MainLauncher = true)]
    public class MainActivity1 : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
         
           
        }

        // Simulates background work that happens behind the splash screen
        async void SimulateStartup()
        {
             await Task.Delay(2000); // Simulate a bit of startup work.
             StartActivity(new Intent(Application.Context, typeof(MainActivity1)));

           
        }
       

    }
}

