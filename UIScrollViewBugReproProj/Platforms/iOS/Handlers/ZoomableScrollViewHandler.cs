using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;

namespace UIScrollViewBugReproProj.Platforms.iOS.Handlers
{
    public class ZoomableScrollViewHandler : ScrollViewHandler
    {
        protected override void ConnectHandler(UIScrollView platformView)
        {
            base.ConnectHandler(platformView);
            if (platformView != null)
            {
                platformView.MinimumZoomScale = 1;
                platformView.MaximumZoomScale = 3;
                platformView.ViewForZoomingInScrollView += (UIScrollView sv) =>
                {
                    return platformView.Subviews[0];
                };
            }
        }
        protected override void DisconnectHandler(UIScrollView platformView)
        {
            base.DisconnectHandler(platformView);
        }
    }
}
