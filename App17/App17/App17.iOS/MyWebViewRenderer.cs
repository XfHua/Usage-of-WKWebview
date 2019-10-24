using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App17;
using App17.iOS;
using Foundation;
using UIKit;
using WebKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyWebView), typeof(MyWebViewRenderer))]
namespace App17.iOS
    {
        public class MyWebViewRenderer : ViewRenderer<MyWebView, WKWebView>
        {
            WKWebView _wkWebView;
            protected override void OnElementChanged(ElementChangedEventArgs<MyWebView> e)
            {
                base.OnElementChanged(e);

                if (Control == null)
                {
                    var config = new WKWebViewConfiguration();
                    _wkWebView = new WKWebView(Frame, config);
                    SetNativeControl(_wkWebView);
                }
                if (e.NewElement != null)
                {
                    Control.LoadRequest(new NSUrlRequest(new NSUrl(Element.Url)));
                }
            }
        }
    }
