using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using App1.Model;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private List<Person> myitems = new List<Person>();
        private ListView mylistview;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mylistview = FindViewById<ListView>(Resource.Id.myListView);

            myitems = new List<Person>();
            
            myitems.Add(new Person { FirstName = "郭", LastName = "富城", Age = "50", Gender = "台北" });
            myitems.Add(new Person { FirstName = "林", LastName = "柏丞", Age = "29", Gender = "桃園" });
            myitems.Add(new Person { FirstName = "張", LastName = "學友", Age = "52", Gender = "香港" });

            MyListViewAdpater adapter = new MyListViewAdpater(this, myitems);

            mylistview.Adapter= adapter;
            mylistview.ItemClick += myListView_ItemClick;
            mylistview.ItemLongClick += myListView_ItemLongClick;


            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }

        void myListView_ItemClick(object sender , AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this,"123", ToastLength.Short).Show();

        }

        void myListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Toast.MakeText(this, "456", ToastLength.Long).Show();

        }
    }
}

