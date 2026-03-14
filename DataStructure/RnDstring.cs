using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataStructure
{
    class RnDstring
    {
        string str = "@iID=132,@cWorkgroupName='1C01',@cBranch='2',@cTeam='127',@cSpecialism='2',@cSalesContoller='297',@iEnabled=0";
        SqlCommand sqlcommand;
        public void BuildParameters()
        {
            string paramValue = string.Empty;
            string paramText = string.Empty;

            string[] strArr = str.Split(',');
            string[] strsplit;
            sqlcommand = new SqlCommand();
            for(int i=0; i< strArr.Length; i++)
            {
                strsplit = strArr[i].Split('=');
                paramText = strsplit[0].Remove(0,1);
                paramValue = strsplit[1];
                if (paramValue.Contains("'"))
                    paramValue = paramValue.Replace("'", "");
                sqlcommand.Parameters.Add(new SqlParameter(paramText,paramValue));
            }
            
        }
        public static void Main()
        {
            RnDstring obj = new RnDstring();
            obj.BuildParameters();
        }
          
    }
}
