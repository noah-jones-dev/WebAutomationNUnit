using NUnitWebAutomationCSharp.Configuration;
using NUnitWebAutomationCSharp.Framework.Fields;
using Bogus;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Pages
{
    public class LoginPage : MenuPage
    {
        //Left Panel Fields
        public TextField LoginUserNameTxt { get; }
        public TextField LoginPasswordTxt { get; }
        public ButtonField LoginBtn { get; }
        public LinkField ForgotLoginInfoLnk { get; }
        public LinkField RegisterLnk { get; }
        
        //Signup Fields
        public TextField FirstNameTxt { get; }
        public TextField LastNameTxt { get; }
        public TextField AddressTxt { get; }
        public TextField CityTxt { get; }
        public TextField StateTxt { get; }
        public TextField ZipCodeTxt { get; }
        public TextField PhoneNumberTxt { get; }
        public TextField SocialSecurityNumberTxt { get; }
        public TextField RegisterUserNameTxt { get; }
        public TextField RegisterPasswordTxt { get; }
        public TextField ConfirmPasswordTxt { get; }
        public ButtonField RegisterBtn { get; }
        
        //Customer Lookup Fields
        public ButtonField FindMyLoginInfoBtn { get; }
        
        public LoginPage()
        {
            //Left Panel Fields
            LoginUserNameTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='username']")});
            LoginPasswordTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='password']")});
            LoginBtn = new ButtonField(Driver, "Log In");
            ForgotLoginInfoLnk = new LinkField(Driver, 
                MenuTypes.MiddleLeft, "Forgot login info?");
            RegisterLnk = new LinkField(Driver, 
                MenuTypes.MiddleLeft, "register");
            
            //Sign Up Fields
            FirstNameTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='customer.firstName']")});
            LastNameTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='customer.lastName']")});
            AddressTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='customer.address.street']")});
            CityTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='customer.address.city']")});
            StateTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='customer.address.state']")});
            ZipCodeTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='customer.address.zipCode']")});
            PhoneNumberTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='customer.phoneNumber']")});
            SocialSecurityNumberTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='customer.ssn']")});
            RegisterUserNameTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='customer.username']")});
            RegisterPasswordTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='customer.password']")});
            ConfirmPasswordTxt = new TextField(Driver, 
                new List<By>{By.XPath("//input[@name='repeatedPassword']")});
            RegisterBtn = new ButtonField(Driver, "Register");
            
            //Customer Lookup Fields
            FindMyLoginInfoBtn = new ButtonField(Driver, "Find My Login Info");
            
        }
        
        //Methods
        public void RegisterUser(string username=null, string password=null)
        {
            Faker faker = new Faker();
            if (username == null && password == null)
            {
                username = faker.Internet.UserName();
                password = faker.Internet.Password();
            }
            RegisterLnk.Click();
            FirstNameTxt.Enter("John");
            LastNameTxt.Enter("Doe");
            AddressTxt.Enter("123 Main St");
            CityTxt.Enter("Mesa");
            StateTxt.Enter("Arizona");
            ZipCodeTxt.Enter("23421");
            PhoneNumberTxt.Enter("1234567689");
            SocialSecurityNumberTxt.Enter("908144567");
            RegisterUserNameTxt.Enter(username);
            RegisterPasswordTxt.Enter(password);
            ConfirmPasswordTxt.Enter(password);
            RegisterBtn.Click();
        }

        public void LoginUser(string username, string password)
        {
            LoginUserNameTxt.Enter(username);
            LoginPasswordTxt.Enter(password);
            LoginBtn.Click();
        }
        
        public LoginPage NavigateTo()
        {
            if (LogOutLnk.Visible())
            {
                LogOutLnk.Click();           
            }
            return this;       
        }
        
    }
}

