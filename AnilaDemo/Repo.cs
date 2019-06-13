using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnilaDemo
{
    public class Repo
    {

        public static By GoogleSearchField = By.XPath("//*[@id='tsf']/div[2]/div/div[1]/div/div[1]/input");
        public static By GoogleSearchBtn = By.XPath("//*[@id='tsf']/div[2]/div/div[3]/center/input[1]");

    }
}
