using System;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FloatingActionButton;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private Fab _fab;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _fab = FindViewById<Fab>(Resource.Id.fabbutton);
            _fab.FabColor = Color.White;
            _fab.FabDrawable = Resources.GetDrawable(Resource.Drawable.ic_content_new);
            _fab.Click += (s, e) => Toast.MakeText(this, "Clicked Fab", ToastLength.Short).Show();
            ActionBar.SetBackgroundDrawable(new ColorDrawable(Color.Black));

            var blue = FindViewById<View>(Resource.Id.blueButton);
            blue.Click += (s, e) =>
            {
                var holoBlue = Resources.GetColor(Android.Resource.Color.HoloBlueLight);
                _fab.FabColor = holoBlue;
                ActionBar.SetBackgroundDrawable(new ColorDrawable(holoBlue));
                _fab.FabDrawable = Resources.GetDrawable(Resource.Drawable.ic_content_new);
            };

            var purple = FindViewById<View>(Resource.Id.purpleButton);
            purple.Click += (s, e) =>
            {
                var holoPurple = Resources.GetColor(Android.Resource.Color.HoloPurple);
                _fab.FabColor = holoPurple;
                ActionBar.SetBackgroundDrawable(new ColorDrawable(holoPurple));
                _fab.FabDrawable = Resources.GetDrawable(Resource.Drawable.ic_content_new);
            };

            var green = FindViewById<View>(Resource.Id.greenButton);
            green.Click += (s, e) =>
            {
                var holoGreen = Resources.GetColor(Android.Resource.Color.HoloGreenLight);
                _fab.FabColor = holoGreen;
                ActionBar.SetBackgroundDrawable(new ColorDrawable(holoGreen));
                _fab.FabDrawable = Resources.GetDrawable(Resource.Drawable.ic_content_new);
            };

            var oraange = FindViewById<View>(Resource.Id.orangeButton);
            oraange.Click += (s, e) =>
            {
                var holoOrange = Resources.GetColor(Android.Resource.Color.HoloOrangeLight);
                _fab.FabColor = holoOrange;
                ActionBar.SetBackgroundDrawable(new ColorDrawable(holoOrange));
                _fab.FabDrawable = Resources.GetDrawable(Resource.Drawable.ic_content_new);
            };

            var red = FindViewById<View>(Resource.Id.redButton);
            red.Click += (s, e) =>
            {
                var holoRed = Resources.GetColor(Android.Resource.Color.HoloRedLight);
                _fab.FabColor = holoRed;
                ActionBar.SetBackgroundDrawable(new ColorDrawable(holoRed));
                _fab.FabDrawable = Resources.GetDrawable(Resource.Drawable.ic_content_new);
            };

            var hide = FindViewById<Button>(Resource.Id.hideButton);
            hide.Click += (s, e) =>
            {
                _fab.Hide(true);
                ActionBar.Hide();
            };

            var show = FindViewById<Button>(Resource.Id.showButton);
            show.Click += (s, e) =>
            {
                _fab.Show(false);
                ActionBar.Show();
            };
        }
    }
}

