using UIKit;

namespace NativeAccess
{
    public partial class DeviceOrientationService
    {
        public partial DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation =
                UIApplication.SharedApplication.StatusBarOrientation;
            bool isPortrait = orientation == UIInterfaceOrientation.Portrait ||
                orientation == UIInterfaceOrientation.PortraitUpsideDown;
            return isPortrait ?
                DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}
