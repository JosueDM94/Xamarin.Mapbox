using Android.Runtime;

namespace Mapbox.MapboxSDK.Utils
{
    public partial class FileUtils
    {
        // Error CS0534: 'FileUtils.CheckFileReadPermissionTask' does not implement inherited abstract member 'AsyncTask.DoInBackground(params Object[])'
        public partial class CheckFileReadPermissionTask : global::Android.OS.AsyncTask
        {
            protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return new Java.Lang.Object(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "doInBackground", "([Ljava/io/File;)Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
            }
        }

        // Error CS0534: 'FileUtils.CheckFileWritePermissionTask' does not implement inherited abstract member 'AsyncTask.DoInBackground(params Object[])'
        public partial class CheckFileWritePermissionTask : global::Android.OS.AsyncTask
        {
            protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
            {
                return new Java.Lang.Object(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "doInBackground", "([Ljava/io/File;)Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
            }
        }
    }
}