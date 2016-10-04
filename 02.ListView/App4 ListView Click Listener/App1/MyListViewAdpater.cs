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
using App1.Model;

namespace App1
{
    class MyListViewAdpater : BaseAdapter<Person>
    {
        private List<Person> mItems;
        private Context mContext;


        public MyListViewAdpater(Context context , List<Person> items)
        {
            mItems = items;
            mContext = context;
        }

      
        public override int Count
        {
            get
            {
                return this.mItems.Count;
            }
        }

        public override Person this[int position]
        {
            get
            {
                return mItems[position];
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.MyListView,null,false);
            }

            row.FindViewById<TextView>(Resource.Id.txtFirstName).Text = mItems[position].FirstName;
            row.FindViewById<TextView>(Resource.Id.txtLastName).Text = mItems[position].LastName;
            row.FindViewById<TextView>(Resource.Id.txtAge).Text = mItems[position].Age;
            row.FindViewById<TextView>(Resource.Id.txtGender).Text = mItems[position].Gender;

            return row;
        }
    }

}