using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using FacebookTest.Base;

namespace FacebookTest.Utilities
{
    public class CustomEventFiringWebDriver
    {
        public EventFiringWebDriver eventFiringWebDriver;

        public CustomEventFiringWebDriver(IWebDriver parentDriver)
        {
            //eventFiringWebDriver = new EventFiringWebDriver(parentDriver);
            //eventFiringWebDriver.ElementClicking += EventFiringWebDriver_ElementClicking;
            //eventFiringWebDriver.ElementClicked += EventFiringWebDriver_ElementClicked;
            //eventFiringWebDriver.ElementValueChanging += EventFiringWebDriver_ElementValueChanging;
            //eventFiringWebDriver.ElementValueChanged += EventFiringWebDriver_ElementValueChanged;
            //eventFiringWebDriver.ExceptionThrown += EventFiringWebDriver_ExceptionThrown;
            //eventFiringWebDriver.FindingElement += EventFiringWebDriver_FindingElement;
            //eventFiringWebDriver.FindElementCompleted += EventFiringWebDriver_FindElementCompleted;
            //eventFiringWebDriver.Navigating += EventFiringWebDriver_Navigating;
            //eventFiringWebDriver.Navigated += EventFiringWebDriver_Navigated;
           // eventFiringWebDriver.NavigatingBack += EventFiringWebDriver_NavigatingBack;
            //eventFiringWebDriver.NavigatedBack += EventFiringWebDriver_NavigatedBack;
            //eventFiringWebDriver.NavigatingForward += EventFiringWebDriver_NavigatingForward;
            // eventFiringWebDriver.NavigatedForward += EventFiringWebDriver_NavigatedForward;
            //eventFiringWebDriver.ScriptExecuting += EventFiringWebDriver_ScriptExecuting;
            //eventFiringWebDriver.ScriptExecuted += EventFiringWebDriver_ScriptExecuted;
        }

        private void EventFiringWebDriver_ScriptExecuted(object sender, WebDriverScriptEventArgs e)
        {
            Console.WriteLine("Executing javascript complete: " + e.Script);
        }

        private void EventFiringWebDriver_ScriptExecuting(object sender, WebDriverScriptEventArgs e)
        {
            Console.WriteLine("Executing javascript: " + e.Script);
        }

        private void EventFiringWebDriver_NavigatedForward(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("Navigating forward complete");
        }

        private void EventFiringWebDriver_NavigatingForward(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("Navigating forward");
        }

        private void EventFiringWebDriver_NavigatedBack(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("Navigating back complete");
        }

        private void EventFiringWebDriver_NavigatingBack(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("Navigating back");
        }

        private void EventFiringWebDriver_Navigated(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("***Navigating to Url complete: " + e.Url);
        }

        private void EventFiringWebDriver_Navigating(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("***Navigating to Url: " + e.Url);
        }

        private void EventFiringWebDriver_FindElementCompleted(object sender, FindElementEventArgs e)
        {
            Console.WriteLine("***Found element: ");
        }

        private void EventFiringWebDriver_FindingElement(object sender, FindElementEventArgs e)
        {
            Console.WriteLine("***Finding element: ");
        }

        private void EventFiringWebDriver_ExceptionThrown(object sender, WebDriverExceptionEventArgs e)
        {
            // Take screenshot
            Console.WriteLine("***Exception occurred : " + e.ThrownException.ToString());
        }

        private void EventFiringWebDriver_ElementValueChanged(object sender, WebElementValueEventArgs e)
        {
            Console.WriteLine("Value changed on element: " + e.Element.ToString());
        }

        private void EventFiringWebDriver_ElementValueChanging(object sender, WebElementValueEventArgs e)
        {
            Console.WriteLine("Value changing on element: " + e.Element.ToString());
        }

        private void EventFiringWebDriver_ElementClicked(object sender, WebElementEventArgs e)
        {
            Console.WriteLine("Clicking completed on element: " + e.Element.ToString());
        }

        private void EventFiringWebDriver_ElementClicking(object sender, WebElementEventArgs e)
        {
            Console.WriteLine("Clicking element: " + e.Element.ToString());
        }

       
    }
}
