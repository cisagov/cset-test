using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Enums.Con_PCA
{
    public enum Env

    {
        [EnvAttr("https://pca.dev.inltesting.xyz/login")] Dev,
        [EnvAttr("http://localhost:4200/login")] Local,
    }

    class EnvAttr : Attribute
    {
        internal EnvAttr(String env)
        {
            this.Value = env;
        }
        public String Value { get; private set; }
    }

    public static class EnvExtensions
    {
        public static String GetValue(this Env enumChoice)
        {
            var attr = enumChoice.GetAttribute<EnvAttr>();
            return attr.Value;
        }
    }
}
