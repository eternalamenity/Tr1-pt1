using Android.App;
using Android.Widget;
using Android.OS;

namespace App18
{
    [Activity(Label = "App18", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Przypadek
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

