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
    [Activity(Label = "Activity3")]
    public class Activity3 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            Button submit = FindViewById<Button>(Resource.Id.btnGetText);
            submit.Click += delegate {

                string strMessage = string.Empty;
                strMessage = FindViewById<TextView>(Resource.Id.feedback).Text;

                Toast.MakeText(this, strMessage, ToastLength.Long).Show();
            };

            RadioButton rdoGC = FindViewById<RadioButton>(Resource.Id.radioButton1);
            rdoGC.Click += onClickRadioButton;

            RadioButton rdoMF = FindViewById<RadioButton>(Resource.Id.radioButton2);
            rdoMF.Click += onClickRadioButton;


            CheckBox chkLike = FindViewById<CheckBox>(Resource.Id.checkLike);

            chkLike.CheckedChange += (sender, e) => {
                CheckBox check = (CheckBox)sender;
                if (check.Checked)
                {
                    check.Text = "Checked";
                }
                else
                {
                    check.Text = "Unchecked";
                }
            };
            Button btnSubmit = FindViewById<Button>(Resource.Id.btnSubmit);
            btnSubmit.Click += delegate {

                Toast.MakeText(this, FindViewById<EditText>(Resource.Id.feedback).Text, ToastLength.Short).Show();

            };
        }
    }
}