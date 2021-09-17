using CSET_Selenium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Opera;

namespace CSET_Selenium.DriverConfiguration
{
    class BaseConfiguration
    {
        private String url = "https://www.google.com";
        private String host = "local"; // change me to grid  or local.
        private String hostURL = "http://10.100.102.130:4444/wd/hub";

        public BaseConfiguration()
        {
        }

        public BaseConfiguration(String url)
        {
            this.url = url;
        }

        private Browsers browser = Browsers.Chrome;

        private bool useCustomProfile = false;
        private String customProfilePath = null;

        private bool useCookies = false;
        private String cookieFileLocation = null;

        private bool useBandwidthProxy = false;
        private int latencyInSeconds = 0;

        private Dictionary<String, Object> customBrowserPrefs = null;

        private bool useMobileEmulation = false;


        public bool IsUseMobileEmulation()
        {
            return useMobileEmulation;
        }

        public void SetUseMobileEmulation(bool useMobileEmulation)
        {
            this.useMobileEmulation = useMobileEmulation;
        }

        public MobileEmulationDevices GetEmulatedDevice()
        {
            return emulatedDevice;
        }

        public void SetEmulatedDevice(MobileEmulationDevices emulateDevice)
        {
            this.emulatedDevice = emulateDevice;
        }

        private MobileEmulationDevices emulatedDevice = MobileEmulationDevices.Nexus_5X;

        // Driver options.
        private EdgeOptions edgeOptions = new EdgeOptions();
        private ChromeOptions chromeOptions = new ChromeOptions();
        private InternetExplorerOptions internetExplorerOptions = new InternetExplorerOptions();
        private FirefoxOptions firefoxOptions = new FirefoxOptions();
        private SafariOptions safariOptions = new SafariOptions();
        private OperaOptions operaOptions = new OperaOptions();

        public String GetUrl()
        {
            return url;
        }

        public void SetUrl(String url)
        {
            this.url = url;
        }

        public String GetCustomProfilePath()
        {
            return customProfilePath;
        }

        public void SetCustomProfilePath(String customProfilePath)
        {
            this.customProfilePath = customProfilePath;
        }

        public String GetCookieFileLocation()
        {
            return cookieFileLocation;
        }

        public void SetCookieFileLocation(String cookieFileLocation)
        {
            this.cookieFileLocation = cookieFileLocation;
        }

        public bool IsUseBandwidthProxy()
        {
            return useBandwidthProxy;
        }

        public void SetUseBandwidthProxy(bool useBandwidthProxy)
        {
            this.useBandwidthProxy = useBandwidthProxy;
        }

        public int GetLatencyInMilliseconds()
        {
            return latencyInSeconds;
        }

        public void SetLatencyInMilliseconds(int latencyInSeconds)
        {
            this.latencyInSeconds = latencyInSeconds;
        }

        public Dictionary<String, Object> GetCustomBrowserPrefs()
        {
            return customBrowserPrefs;
        }

        public void SetCustomBrowserPrefs(Dictionary<String, Object> customBrowserPrefs)
        {
            this.customBrowserPrefs = customBrowserPrefs;
        }

        public Browsers GetBrowser()
        {
            return browser;
        }

        public void SetBrowser(Browsers browser)
        {
            this.browser = browser;
        }

        public bool IsUseCookies()
        {
            return useCookies;
        }

        public void SetUseCookies(bool useCookies)
        {
            this.useCookies = useCookies;
        }

        public bool IsUseCustomProfile()
        {
            return useCustomProfile;
        }

        public void SetUseCustomProfile(bool useCustomProfile)
        {
            this.useCustomProfile = useCustomProfile;
        }

        public String GetHost()
        {
            return host;
        }

        public void SetHost(String host)
        {
            this.host = host;
        }

        public EdgeOptions GetEdgeOptions()
        {
            return edgeOptions;
        }

        public void SetEdgeOptions(EdgeOptions edgeOptions)
        {
            this.edgeOptions = edgeOptions;
        }

        public ChromeOptions GetChromeOptions()
        {
            return chromeOptions;
        }

        public void SetChromeOptions(ChromeOptions chromeOptions)
        {
            this.chromeOptions = chromeOptions;
        }

        public InternetExplorerOptions GetInternetExplorerOptions()
        {
            internetExplorerOptions.AddAdditionalCapability("ie.ensureCleanSession", true);
            return internetExplorerOptions;
        }

        public void SetInternetExplorerOptions(InternetExplorerOptions internetExplorerOptions)
        {
            this.internetExplorerOptions = internetExplorerOptions;
        }

        public FirefoxOptions GetFirefoxOptions()
        {
            firefoxOptions.AddAdditionalCapability("marionette", true);
            return firefoxOptions;
        }

        public void SetFirefoxOptions(FirefoxOptions firefoxOptions)
        {
            this.firefoxOptions = firefoxOptions;
        }

        public String GetHostUrl()
        {
            return hostURL;
        }

        public void SetHostUrl(String hostUrl)
        {
            this.hostURL = hostUrl;
        }

        public SafariOptions GetSafariOptions()
        {
            return safariOptions;
        }

        public void SetSafariOptions(SafariOptions safariOptions)
        {
            this.safariOptions = safariOptions;
        }
    }
}
