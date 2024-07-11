using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Navigate to the main page
            driver.Navigate().GoToUrl("https://miacademy.co/#/");
            Console.WriteLine("Navigated to miacademy.co");

            // Wait for the page to load
            System.Threading.Thread.Sleep(2000); 

            // Navigate to MiaPrep Online High School through the link on the banner
            IWebElement miaPrepLink = driver.FindElement(By.XPath("//a[contains(text(), 'Online High School')]"));
            miaPrepLink.Click();
            Console.WriteLine("Clicked on MiaPrep Online High School link");

            // Wait for the page to load
            System.Threading.Thread.Sleep(2000);

            // Click on the apply button for MOHS
            IWebElement applyButton = driver.FindElement(By.XPath("//a[contains(text(), 'Take the Quiz')]"));
            applyButton.Click();
            Console.WriteLine("Clicked on Apply to MOHS");

            // Wait for the page to load
            System.Threading.Thread.Sleep(2000); 

            IWebElement nextButton1 = driver.FindElement(By.XPath("//button[@elname='next']"));
            nextButton1.Click();
            Console.WriteLine("Clicked on Next Button");

            // Fill in the Parent Information
            driver.FindElement(By.XPath("//input[@elname='First' and @name='Name']")).SendKeys("John");
            driver.FindElement(By.XPath("//input[@elname='Last' and @name='Name']")).SendKeys("Doe");

            driver.FindElement(By.XPath("//input[@name='Email']")).SendKeys("john.doe@example.com");
            driver.FindElement(By.XPath("//input[@name='PhoneNumber']")).SendKeys("1234567890");
            Console.WriteLine("Filled in Parent Information");

            // Interact with the dropdown to select "Yes"
            IWebElement dropdown = driver.FindElement(By.XPath("//span[@class='select2-selection select2-selection--single select2FormCont']"));
            dropdown.Click();
            System.Threading.Thread.Sleep(1000); // Wait for the dropdown options to appear

            IWebElement yesOption = driver.FindElement(By.XPath("//li[contains(text(), 'Yes')]"));
            yesOption.Click();
            Console.WriteLine("Selected 'Yes' option from the dropdown");

            //Select the date

            IWebElement datePicker = driver.FindElement(By.XPath("//input[@name='Date']"));
            datePicker.Click();
            Console.WriteLine("datePicker");

            IWebElement selectDay = driver.FindElement(By.XPath("//a[contains(text(), '25')]"));
            selectDay.Click();
            Console.WriteLine("datePicker33");


            // Proceed to the Student Information page
            IWebElement nextButton = driver.FindElement(By.XPath("//button[contains(@aria-label, 'page 3 out of 4') and .//em[text()=' Next ']]"));
            nextButton.Click();
            Console.WriteLine("Proceeded to Student Information page");

            // Stop the test here
            Console.WriteLine("Test completed. Stopping here.");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
        finally
        {
            // Close the browser
            driver.Quit();
        }
    }
}
