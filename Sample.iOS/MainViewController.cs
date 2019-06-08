using CoreLocation;
using Foundation;
using Mapbox;
using UIKit;

namespace MapboxSDKSample.iOS
{
    public partial class MainViewController : UIViewController, IMGLMapViewDelegate
    {
        public MainViewController() : base("MainViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var mapView = new MGLMapView(View.Bounds, new NSUrl("mapbox://styles/josuedm94/cjrtnhyp3kf2p2sl33mxaa5tt"));
            mapView.SetCenterCoordinate(new CLLocationCoordinate2D(40.74699, -73.98742), 9, false);
            mapView.AutoresizingMask = UIViewAutoresizing.FlexibleDimensions;
            View.AddSubview(mapView);

            var annotation = new MGLPointAnnotation();
            annotation.Coordinate = new CLLocationCoordinate2D(40.77014, -73.97480);
            annotation.Title = "Central Park";
            annotation.Subtitle = "The biggest park in New York City!";
            mapView.AddAnnotation(annotation);

            mapView.WeakDelegate = this;
            mapView.ShowsUserLocation = true;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        [Export("mapView:annotationCanShowCallout:")]
        public bool AnnotationCanShowCallout(MGLMapView mapView, MGLAnnotation annotation)
        {
            return true;
        }

        [Export("mapView:didSelectAnnotation:")]
        public void DidSelectAnnotation(MGLMapView mapView, MGLAnnotation annotation)
        {
            var camera = MGLMapCamera.CameraLookingAtCenterCoordinateFromDistance(annotation.Coordinate, 4500, 15, 180);
            mapView.FlyToCamera(camera, 4, 300, null);
        }
    }
}