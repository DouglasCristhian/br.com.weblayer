using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace br.com.weblayer
    {
    [Activity(Label = "Weblayer")]
    public class MainActivity : Activity

    {
        protected override void OnCreate(Bundle bundle)
        {

			SetTheme(Resource.Style.CustomTheme);

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
                Window.SetStatusBarColor(Resources.GetColor(Resource.Color.my_colorprimaryDark));
            }

             

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }
    }
}

