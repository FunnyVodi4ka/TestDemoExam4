using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemoExam4.DatabaseConnection
{
    public partial class Users
    {
        public string CorrectImage
        {
            get
            {
                if(File.Exists(System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Resources\\UserImages\\" +  pImage))
                {
                    return System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Resources\\UserImages\\" + pImage;
                }
                else
                {
                    return "/Resources/AppImages/DefaultPicture.png";
                }
            }
        }

        public string CorrectBackground
        {
            get
            {
                if (pCost < 100)
                {
                    return "Gray";
                }
                else if(pCost >= 100 && pCost <= 1000)
                {
                    return "Yellow";
                }
                else
                {
                    return "Red";
                }
            }
        }

        public string CorrectCostLine
        {
            get
            {
                if(pCost <= 500)
                {
                    return "Strikethrough";
                }
                else
                {
                    return "None";
                }
            }
        }
    }
}
