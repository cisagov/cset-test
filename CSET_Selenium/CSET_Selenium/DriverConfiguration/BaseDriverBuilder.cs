using CSET_Selenium.Enums;
using CSET_Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CSET_Selenium.DriverConfiguration
{
    class BaseDriverBuilder
    {
        //private ThreadLocal<IWebDriver> tlwd = new ThreadLocal<IWebDriver>();
        IWebDriver driver = null;
        private BaseConfiguration cf;

        public IWebDriver BuildWebDriver(Object builderConfiguration)
        {
            this.cf = (BaseConfiguration)builderConfiguration;
            //SetProxy();
            SetMobile();
            SetCustomProfile();

            if (cf.GetBrowser().Equals(Browsers.Chrome))
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                ChromeConfig config = new ChromeConfig();
                Dictionary<String, Object> chromePrefs = new Dictionary<String, Object>();
                if (this.cf.GetCustomBrowserPrefs() != null)
                {
                    chromePrefs = this.cf.GetCustomBrowserPrefs();
                }
                else
                {
                    chromePrefs.Add("safebrowsing.enabled", true);
                    chromePrefs.Add("download.prompt_for_download", false);
                }
                foreach (KeyValuePair<String, Object> preference in chromePrefs)
                {
                    cf.GetChromeOptions().AddUserProfilePreference(preference.Key, preference.Value);
                }
                cf.GetChromeOptions().AddArgument("disable-popup-blocking");
                cf.GetChromeOptions().AddArgument("start-maximized");
                cf.GetChromeOptions().AddArgument("disable-infobars");
                cf.GetChromeOptions().AddArgument("no-sandbox");
                cf.GetChromeOptions().AddArgument("download.default_directory");
                //driver = new ChromeDriver(cf.GetChromeOptions());
                driver = new ChromeDriver(ChromeDriverService.CreateDefaultService(), cf.GetChromeOptions(), TimeSpan.FromMinutes(3));
            }
            else if (cf.GetBrowser().Equals(Browsers.Edge))
            {
                new DriverManager().SetUpDriver(new EdgeConfig());
                driver = new EdgeDriver(cf.GetEdgeOptions());
            }
            /*else if (cf.GetBrowser().Equals(Browsers.InternetExplorer))
            {
                new DriverManager().SetUpDriver(new InternetExplorerConfig());
                driver = new InternetExplorerDriver(cf.GetInternetExplorerOptions());
            }
            else if (cf.GetBrowser().Equals(Browsers.Firefox))
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver(cf.GetFirefoxOptions());
            }*/
            if (driver != null)
            {
                driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(cf.GetPageLoadTimeoutInSeconds()));
                driver.Navigate().GoToUrl(cf.GetUrl());
                new WaitUtils(driver).WaitForPageLoad();
            }
            else
            {
                throw new WebDriverException();
            }
            return driver;
        }

        //Not Yet Implemented for Parallel Test Execution
        /*//If you pass in custom browser prefs, it is assumed that you know exactly what you want to do, and should therefore be putting all prefs
        //that you want into the dictionary. Please see below for the standard prefs that are implemented if you need a starting point.
        private void RemoteWebDriver()
        {
            URL remoteUrl = new URL(cf.getHostUrl());
            if (cf.GetBrowser().Equals(Browsers.Chrome)) {
                HashMap<String, Object> chromePrefs = new HashMap<String, Object>();
                if (this.cf.getCustomBrowserPrefs() != null) {
                    chromePrefs = this.cf.getCustomBrowserPrefs();
                } else {
                    chromePrefs.put("safebrowsing.enabled", true);
                    chromePrefs.put("download.prompt_for_download", true);
                }
                cf.getChromeOptions().setExperimentalOption("prefs", chromePrefs).addArguments(Arrays.asList("window-size=1920,1080", "whitelisted-ips=''"));
                cf.getChromeOptions().setCapability("idleTimeout", 999);
                cf.getChromeOptions().setCapability("maxDuration", 10800);
                tlwd.set(new CustomRemoteIWebDriver(cf, remoteUrl, cf.getChromeOptions()));
            } else if (cf.GetBrowser().Equals(Browsers.Edge)) {
                System.setProperty("IWebDriver.edge.driver", exportResource("MicrosoftIWebDriver.exe"));
                tlwd.set(new CustomRemoteIWebDriver(cf, remoteUrl, cf.getEdgeOptions()));
            } else if (cf.GetBrowser().Equals(Browsers.InternetExplorer)) {
                System.setProperty("IWebDriver.ie.driver", exportResource("IEDriverServer.exe"));
                tlwd.set(new CustomRemoteIWebDriver(cf, remoteUrl, cf.getInternetExplorerOptions()));
            } else if (cf.GetBrowser().Equals(Browsers.Firefox)) {
                System.setProperty("IWebDriver.gecko.driver", exportResource("geckodriver.exe"));
                tlwd.set(new CustomRemoteIWebDriver(cf, remoteUrl, cf.getFirefoxOptions()));
            } else if (cf.GetBrowser().Equals(Browsers.Safari)) {
                System.setProperty("IWebDriver.safari.driver", exportResource("safari.exe"));
                tlwd.set(new CustomRemoteIWebDriver(cf, remoteUrl, cf.getSafariOptions()));
            }
            tlwd.get().get(cf.getUrl());
            WaitForPageToLoad();
        }

        public Synchronized IWebDriver GetWebDriver()
        {
            return tlwd.get();
        }

        public void Quit()
        {
            if (tlwd.get() != null)
            {
                tlwd.get().quit();
                tlwd.remove();
            }
        }*/

        /**
         * Only for chrome mobile emulation currently;
         */
        private void SetMobile()
        {
            if (cf.IsUseMobileEmulation())
            {
                Dictionary<String, String> mobileEmulation = new Dictionary<String, String>();
                cf.GetChromeOptions().EnableMobileEmulation(cf.GetEmulatedDevice().GetValue());
            }
        }

        private void SetCustomProfile()
        {
            if (cf.IsUseCustomProfile())
            {
                cf.GetChromeOptions().AddArgument("user-data-dir=" + cf.GetCustomProfilePath());
            }
        }

        //Not Yet Implemented
        /* private void setCookies()
         {
             if (cf.isUseCookies())
             {
                 try
                 {
                     File file = new File(cf.getCookieFileLocation());
                     FileReader fileReader = new FileReader(file);
                     BufferedReader bufferedReader = new BufferedReader(fileReader);

                     String strline;
                     while ((strline = bufferedReader.readLine()) != null)
                     {
                         StringTokenizer token = new StringTokenizer(strline, ";");

                         while (token.hasMoreTokens())
                         {
                             String name = token.nextToken();
                             String value = token.nextToken();
                             String domain = token.nextToken();
                             String path = token.nextToken();
                             Date expiry = null;
                             String possibleExpDateValue;
                             if (!(possibleExpDateValue = token.nextToken()).Equals("null"))
                             {
                                 try
                                 {
                                     SimpleDateFormat format = new SimpleDateFormat("EEE MMM dd HH:mm:ss zzz yyyy");
                                     expiry = format.parse(possibleExpDateValue);
                                 }
                                 catch (ParseException dateError)
                                 {
                                     System.err.println("Error parsing the passed in date.");
                                 }
                             }

                             Boolean isSecure = (Boolean.valueOf(token.nextToken()));
                             Cookie seleniumCookie = new Cookie(name, value, domain, path, expiry, isSecure.booleanValue());
                             getIWebDriver().manage().addCookie(seleniumCookie);
                         }
                     }

                     bufferedReader.close();
                 }
                 catch (FileNotFoundException fne)
                 {
                     fne.printStackTrace();
                 }
                 catch (IOException e)
                 {
                     e.printStackTrace();
                 }
             }

         }

         public void CreateDriverSessionCookieFile(String fileNamePath)
         {
             File file = new File(fileNamePath);
             cf.setCookieFileLocation(file.getAbsolutePath());
             try
             {
                 file.delete();
                 file.createNewFile();
                 FileWriter fileWriter = new FileWriter(file);
                 BufferedWriter bufferedWriter = new BufferedWriter(fileWriter);
                 Iterator<Cookie> cookieIterator = getIWebDriver().manage().getCookies().iterator();

                 while (cookieIterator.hasNext())
                 {
                     Cookie seleniumCookie = cookieIterator.next();
                     bufferedWriter.write(seleniumCookie.getName() + ";" + seleniumCookie.getValue() + ";" + seleniumCookie.getDomain() + ";" + seleniumCookie.getPath() + ";" + seleniumCookie.getExpiry() + ";" + seleniumCookie.isSecure());
                     bufferedWriter.newLine();
                 }

                 bufferedWriter.flush();
                 bufferedWriter.close();
                 fileWriter.close();
             }
             catch (Exception fileError)
             {
                 fileError.printStackTrace();
             }

         }

         private String ExportResource(String resourceName)
         {
             InputStream stream = null;
             FileOutputStream resStreamOut = null;

             String jarFolder;
             try {
                 stream = BaseDriverBuilder.class.getResourceAsStream(resourceName);//note that each / is a directory down in the "jar tree" been the jar the root of the tree
                 if (stream == null) {
                     throw new Exception("Cannot get resource \"" + resourceName + "\" from Jar file.");
                 }

                 jarFolder = (new File(BaseDriverBuilder.class.getProtectionDomain().getCodeSource().getLocation().toURI().getPath())).getParentFile().getPath().replace('\\', '/');
                 File f = new File(jarFolder + "/" + resourceName);
                 if (!f.exists())
                 {
                     byte[] buffer = new byte[4096];
                     resStreamOut = new FileOutputStream(jarFolder + "/" + resourceName);

                     int readBytes;
                     while ((readBytes = stream.read(buffer)) > 0)
                     {
                         resStreamOut.write(buffer, 0, readBytes);
                     }
                 }
             } catch (Exception var10)
             {
                 throw var10;
             }
             finally
             {
                 stream.close();
                 if (resStreamOut != null)
                 {
                     resStreamOut.close();
                 }

             }

             if (resStreamOut != null)
             {
                 System.out.println("Driver successfully extracted to: " + jarFolder + "/" + resourceName);
             }
             else
             {
                 System.out.println("Driver already exists at: " + jarFolder + "/" + resourceName);
             }

             return jarFolder + "/" + resourceName;
         }*/
    }
}
