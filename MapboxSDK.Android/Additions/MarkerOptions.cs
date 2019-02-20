using Android.Runtime;

namespace Mapbox.Mapboxsdk.Annotations
{
    public partial class MarkerOptions //: global::Mapbox.Mapboxsdk.Annotations.BaseMarkerOptions, global::Android.OS.IParcelable
    {
        //protected override Java.Lang.Object RawMarker
        //{
        //    get
        //    {
        //        return new Java.Lang.Object(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "getMarker", "()Lcom/mapbox/mapboxsdk/annotations/Marker;")), JniHandleOwnership.TransferLocalRef);
        //    }
        //}

        //// Error CS0534: 'MarkerOptions' does not implement inherited abstract member 'BaseMarkerOptions.RawThis.get'
        //protected override Java.Lang.Object RawThis
        //{
        //    get
        //    {
        //        return new Java.Lang.Object(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "getThis", "()Lcom/mapbox/mapboxsdk/annotations/BaseMarkerOptions;")), JniHandleOwnership.TransferLocalRef);
        //    }
        //}
    }
}
