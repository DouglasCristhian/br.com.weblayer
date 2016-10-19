using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using br.com.weblayer.Adapter;
using System.Collections.Generic;
using br.com.weblayer.Model;

namespace br.com.weblayer
    {
    [Activity(Label = "Weblayer")]
    public class MainActivity : Activity
    {

        List<Produto> Items;
        ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {

			SetTheme(Resource.Style.CustomTheme);

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
                Window.SetStatusBarColor(Resources.GetColor(Resource.Color.my_colorprimaryDark));
            }

            base.OnCreate(savedInstanceState);

            SetContentView (Resource.Layout.home);

            listView = FindViewById<ListView>(Resource.Id.List); // get reference to the ListView in the layout

            Items = new List<Produto>();
            Items.Add(new Produto { Text = "w/embarcador", ImageResourceId = Resource.Mipmap.ic_launcher });
            Items.Add(new Produto { Text = "w/venda", ImageResourceId = Resource.Mipmap.ic_launcher });
            Items.Add(new Produto { Text = "w/suporte", ImageResourceId = Resource.Mipmap.ic_launcher });

            listView.Adapter = new produtosviewAdapter(this, Items);

            listView.ItemClick += OnListItemClick;
        }

        void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var listView = sender as ListView;
            var t = Items[e.Position];
            Android.Widget.Toast.MakeText(this, t.Text, Android.Widget.ToastLength.Short).Show();
        }

    }
}

