//####################################################################
// ASSEMBLY:        SrTest.Tools.Support.ConstantsHelper
// AUTOR:           Alexander Gonzalez 
// DESCRIPTION:     Initial Arquitecture application 
// DATE:            01/16/2019
//####################################################################


namespace SrTest.Tools.Support
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class ConstantsHelper
    {
        /// <summary>
        /// Resource for get all Employees
        /// </summary>
        public const string UrlGetEmployees = "http://masglobaltestapi.azurewebsites.net/api/Employees";

        public const string UrlGetInternalEmployees = "http://localhost:50115/";

    }
}
