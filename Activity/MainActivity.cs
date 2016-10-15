using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace br.com.weblayer
    {
    [Activity(Label = "Weblayer")]
    public class MainActivity : Activity

    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

			SetTheme(Resource.Style.CustomTheme);

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
                Window.SetStatusBarColor(Resources.GetColor(Resource.Color.my_colorprimaryDark));
            }

            base.OnCreate(savedInstanceState);

            SetContentView (Resource.Layout.Main);

        }
    }
}

