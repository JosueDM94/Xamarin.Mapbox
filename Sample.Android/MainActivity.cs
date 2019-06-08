using Android.OS;
using Android.App;
using Mapbox.Mapboxsdk.Maps;
using Android.Support.V7.App;

namespace Sample.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnMapReadyCallback
    {
        private MapView mapView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Mapbox access token is configured here. This needs to be called either in your application
            // object or in the same activity which contains the mapview.
            Mapbox.Mapboxsdk.Mapbox.GetInstance(this, "pk.eyJ1Ijoiam9zdWVkbTk0IiwiYSI6ImNqcmJpM292dTA2Z3g0M3BzOTBmdDdia3QifQ.sdV0S1mtV2cKehJAekVNOg");
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            mapView = FindViewById<MapView>(Resource.Id.mapView);
            mapView.OnCreate(savedInstanceState);
            mapView.GetMapAsync(this);
        }

        // Add the mapView lifecycle to the activity's lifecycle methods
        protected override void OnResume()
        {
            base.OnResume();
            mapView.OnResume();
        }

        protected override void OnStart()
        {
            base.OnStart();
            mapView.OnStart();
        }

        protected override void OnStop()
        {
            base.OnStop();
            mapView.OnStop();
        }

        protected override void OnPause()
        {
            base.OnPause();
            mapView.OnPause();
        }

        public override void OnLowMemory()
        {
            base.OnLowMemory();
            mapView.OnLowMemory();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            mapView.OnDestroy();
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            mapView.OnSaveInstanceState(outState);
        }

        public void OnMapReady(MapboxMap p0)
        {
            p0.SetStyle("mapbox://styles/josuedm94/cjrtnhyp3kf2p2sl33mxaa5tt");
        }
    }
}