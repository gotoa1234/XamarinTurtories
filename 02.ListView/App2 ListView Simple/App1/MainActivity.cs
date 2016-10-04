using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private List<string> myitems = new List<string>();
        private ListView mylistview;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mylistview = FindViewById<ListView>(Resource.Id.myListView);

            myitems = new List<string>();
            
            myitems.Add("hi");
            myitems.Add("hi2");
            myitems.Add("hi3");

            MyListViewAdpater adapter = new MyListViewAdpater(this, myitems);
            

            mylistview.Adapter= adapter;



            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

