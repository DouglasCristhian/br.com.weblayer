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
using br.com.weblayer.Model;

namespace br.com.weblayer.Adapter
{
    public class produtosviewAdapter : BaseAdapter<Produto>
    {
        List<Produto> items;
        Activity context;
        public produtosviewAdapter(Activity context, List<Produto> items): base()
        {
            this.context = context;
            this.items = items;
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override Produto this[int position]
        {
            get { return items[position]; }
        }
        public override int Count
        {
            get { return items.Count; }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            if (view == null) 
                view = context.LayoutInflater.Inflate(Resource.Layout.produtosviewrow, parent, false);

            view.FindViewById<TextView>(Resource.Id.Text1).Text = items[position].Text;
            view.FindViewById<ImageView>(Resource.Id.Image).SetImageResource(items[position].ImageResourceId);

            return view;
        }

    }
}