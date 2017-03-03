using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinApp1.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]
namespace XamarinApp1.iOS
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl
                (new NSUrl("tel:" + number));
        }
    }
}