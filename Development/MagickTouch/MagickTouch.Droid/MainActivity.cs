using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using static Android.Resource;

namespace MagickTouch.Droid
{
    [Activity(Label = "MagickTouch.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        ImageView iw;
        Button button;

        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            button = FindViewById<Button>(Resource.Id.myButton);

            iw = FindViewById<ImageView>(Resource.Id.imageView1);

            iw.Touch += TouchMeImageViewOnTouch;

            iw.SetColorFilter(Android.Graphics.Color.Argb(255, 128, 128, 128));

            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks!", count++);
            };

        }

        private void TouchMeImageViewOnTouch(object sender, View.TouchEventArgs touchEventArgs)
        {
            switch (touchEventArgs.Event.Action)
            {
                case MotionEventActions.Down:
                    button.Text = "0";
                    iw.SetColorFilter(Android.Graphics.Color.Argb(255, 0, 128, 0));
                    break;
                case MotionEventActions.Pointer1Down:
                    button.Text = "1";
                    
                break;
                case MotionEventActions.Pointer2Down:
                    button.Text = "2";
                    iw.SetColorFilter(Android.Graphics.Color.Argb(255, 128, 0, 0));
                    break;
                case MotionEventActions.Pointer3Down:
                    iw.SetColorFilter(Android.Graphics.Color.Argb(255, 128, 0, 0));
                    button.Text = "3";
                break;
                default:
                    // button.Text = "";
                    // iw.SetColorFilter(Android.Graphics.Color.Argb(255, 128, 128, 128));
                    break;
            }
        }

    }

    }


