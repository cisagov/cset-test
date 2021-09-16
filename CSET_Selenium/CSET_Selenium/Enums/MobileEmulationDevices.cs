using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums
{
    public enum MobileEmulationDevices
    {
        [MobileEmulationDevicesAttr("BlackBerry Z30")] BlackBerry_Z30,
        [MobileEmulationDevicesAttr("Blackberry PlayBook")] Blackberry_PlayBook,
        [MobileEmulationDevicesAttr("Galaxy Note 3")] Galaxy_Note_3,
        [MobileEmulationDevicesAttr("Galaxy Note II")] Galaxy_Note_II,
        [MobileEmulationDevicesAttr("Galaxy S III")] Galaxy_S_III,
        [MobileEmulationDevicesAttr("Galaxy S5")] Galaxy_S5,
        [MobileEmulationDevicesAttr("Kindle Fire HDX")] Kindle_Fire_HDX,
        [MobileEmulationDevicesAttr("LG Optimus L70")] LG_Optimus_L70,
        [MobileEmulationDevicesAttr("Laptop with HiDPI screen")] Laptop_With_HiDPI_Screen,
        [MobileEmulationDevicesAttr("Laptop with MDPI screen")] Laptop_With_MDPI_Screen,
        [MobileEmulationDevicesAttr("Laptop with touch")] Laptop_With_Touch,
        [MobileEmulationDevicesAttr("Microsoft Lumia 550")] Microsoft_Lumia_550,
        [MobileEmulationDevicesAttr("Microsoft Lumia 950")] Microsoft_Lumia_950,
        [MobileEmulationDevicesAttr("Nexus 10")] Nexus_10,
        [MobileEmulationDevicesAttr("Nexus 4")] Nexus_4,
        [MobileEmulationDevicesAttr("Nexus 5")] Nexus_5,
        [MobileEmulationDevicesAttr("Nexus 5X")] Nexus_5X,
        [MobileEmulationDevicesAttr("Nexus 6")] Nexus_6,
        [MobileEmulationDevicesAttr("Nexus 6P")] Nexus_6P,
        [MobileEmulationDevicesAttr("Nexus 7")] Nexus_7,
        [MobileEmulationDevicesAttr("Nokia Lumia 520")] Nokia_Lumia_520,
        [MobileEmulationDevicesAttr("Nokia N9")] Nokia_N9,
        [MobileEmulationDevicesAttr("iPad")] iPad,
        [MobileEmulationDevicesAttr("iPad Pro")] iPad_Pro,
        [MobileEmulationDevicesAttr("iPad Mini")] iPad_Mini,
        [MobileEmulationDevicesAttr("iPhone 4")] iPhone_4,
        [MobileEmulationDevicesAttr("iPhone 5")] iPhone_5,
        [MobileEmulationDevicesAttr("iPhone 6")] iPhone_6,
        [MobileEmulationDevicesAttr("iPhone 6 Plus")] iPhone_6_Plus
    }

    class MobileEmulationDevicesAttr : Attribute
    {
        internal MobileEmulationDevicesAttr(String type)
        {
            this.Value = type;
        }
        public String Value { get; private set; }
    }

    public static class MobileEmulationDevicesExtensions
    {
        public static String GetValue(this MobileEmulationDevices enumChoice)
        {
            var attr = enumChoice.GetAttribute<MobileEmulationDevicesAttr>();
            return attr.Value;
        }
    }
}
