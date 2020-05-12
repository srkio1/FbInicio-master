using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.FacebookClient;
using Android.Content;
using Java.Security;

namespace PedidosNM.Droid
{
    [Activity(Label = "PedidosNM", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            FacebookClientManager.Initialize(this);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            //try
            //{
            //    PackageInfo info = Android.App.Application.Context.PackageManager.GetPackageInfo(Android.App.Application.Context.PackageName, PackageInfoFlags.Signatures);
            //    foreach (var signature in info.Signatures)
            //    {
            //        MessageDigest md = MessageDigest.GetInstance("SHA");
            //        md.Update(signature.ToByteArray());
            //        System.Diagnostics.Debug.WriteLine("##########KEY HASH################");
            //        System.Diagnostics.Debug.WriteLine(Convert.ToBase64String(md.Digest()));
            //    }
            //}
            //catch (NoSuchAlgorithmException e)
            //{
            //    System.Diagnostics.Debug.WriteLine(e);
            //}
            //catch (Exception e)
            //{
            //    System.Diagnostics.Debug.WriteLine(e);
            //}
         
            LoadApplication(new App());
        }
      

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent intent)
        {
            base.OnActivityResult(requestCode, resultCode, intent);
            FacebookClientManager.OnActivityResult(requestCode, resultCode, intent);
        }
    }
}