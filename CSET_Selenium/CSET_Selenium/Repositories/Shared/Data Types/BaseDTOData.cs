using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSET_Selenium.Repositories.Shared.Data_Types
{
    public class BaseDTOData
    {
        public virtual bool IsValid()
        {
            return true;
        }
    }

    public static class DataTypeValidation
    {
        public static bool IsValid(this BaseDTOData dataToValidate)
        {
            return dataToValidate.IsValid();
        }
    }
}
