using System;
using System.Drawing;
using System.Windows.Forms;

namespace IT391_Crooks_Unit6_PartB
{
    public partial class Form1 : Form
    {
        //Initialize the form.
        public Form1()
        {
            InitializeComponent();
        }

        //When the phone number checkbox is clicked,
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //If the email checkbox is already checked,
            if (checkBox1.Checked == true)
                //Uncheck it.
                checkBox2.Checked = false;
        }

        //When the email checkbox is clicked,
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //If the phone number checkbox is already checked,
            if (checkBox2.Checked == true)
                //Uncheck it.
                checkBox1.Checked = false;
        }

        //When the submit button is clicked,
        private void button2_Click(object sender, EventArgs e)
        {
            //Initialize two strings and an int to keep track of the input name, contact information,
            //and the number of fields left blank (also give those values names to help the code be more readable.
            string name = textBox1.Text;
            string contactInfo = textBox2.Text;
            int blankFields = 0;
            //Set the error dialog box to be blank.
            textBox3.Text = "";
            //Set the error box colour to an angry red.
            textBox3.ForeColor = Color.DarkRed;

            //If the name field is empty,
            if (name.Length == 0)
                //keep track of that.
                blankFields++;
            //If the contact information field is empty,
            if (contactInfo.Length == 0)
                //keep track of that.
                blankFields++;
            //If the checkboxes are empty,
            if (checkBox1.Checked == false && checkBox2.Checked == false)
                //keep track of that.
                blankFields++;

            //If there are empty fields,
            if (blankFields > 0)
            {
                //If there is only one empty field,
                if (blankFields == 1)
                {
                    //Set the form title to indicate input errors for easy user viewing.
                    Form1.ActiveForm.Text = "Coffee Bob's Waitlist (blank input error encountered)";
                    //Tell the user, and have the message pop up.
                    textBox3.Text = "It looks like you have an input that you still need to fill out.";
                    textBox3.Visible = true;
                }
                //If there are more,
                else
                {
                    //Set the form title to indicate input errors for easy user viewing.
                    Form1.ActiveForm.Text = "Coffee Bob's Waitlist (blank input error encountered)";
                    //Tell the user with plural language, and have the message pop up.
                    textBox3.Text = "It looks like you have " + blankFields + " inputs that you still need to fill out.";
                    textBox3.Visible = true;
                }
                //Do not parse inputs for validation, as we cannot use this data anyways.
                return;
            }

            //If the name field contains errors,
            if (!validateName(name))
            {
                //Set the form title to indicate input errors for easy user viewing.
                Form1.ActiveForm.Text = "Coffee Bob's Waitlist (name input error encountered)";
                //Tell the user and have the message pop up.
                textBox3.Text = "Your name seems to contain invalid input. Please make sure it uses only basic characters, periods, spaces, and hyphens.";
                textBox3.Visible = true;
            }

            //If the phone number contact method is selected,
            if (checkBox1.Checked == true)
            {
                //If the name field contains errors,
                if (!(validateContact(contactInfo, "phone") == true))
                {
                    //Set the form title to indicate input errors for easy user viewing.
                    Form1.ActiveForm.Text = "Coffee Bob's Waitlist (phone input error encountered)";
                    //Tell the user and have the message pop up.
                    textBox3.Text = "It seems your phone number cannot be processed. Make sure it's 10 digits long with only numbers. Parentheses and a hyphen are not required, but can be accepted.";
                    textBox3.Visible = true;
                }
            }

            //If the email address contact method is selected,
            if (checkBox2.Checked == true)
            {
                //If the name field contains errors,
                if (!(validateContact(contactInfo, "email") == true))
                {
                    //Set the form title to indicate input errors for easy user viewing.
                    Form1.ActiveForm.Text = "Coffee Bob's Waitlist (email input error encountered)";
                    //Tell the user and have the message pop up.
                    textBox3.Text = "We had trouble processing your email. Please ensure it has both an '@' and an extension such as 'gmail.com'";
                    textBox3.Visible = true;
                }
            }
            //If there were no errors,
            if (textBox3.Text.Length == 0)
            {
                //Make sure the form title does not indicate there are errors.
                Form1.ActiveForm.Text = "Coffee Bob's Waitlist";
                //Set the colour to a friendly green,
                textBox3.ForeColor = Color.DarkGreen;
                //and tell the user their submission is taken properly. Also have the message pop up.
                textBox3.Text = "Your information has been delivered to Coffee Bob himself! We'll reach out to you when they can seat you.";
                textBox3.Visible = true;
            }
        }

        //Create a method to handle contact information validation.
        public bool validateContact(string input, string method)
        {
            //Create a boolean and an int to handle proper validation and the number of numbers given in the input respectively.
            bool validated = false;
            int numOfNums = 0;
            //If the contact method selected is the phone number,
            if (method == "phone")
            {
                //While we still have characters to parse,
                for (int i = 0; i < input.Length; i++)
                {
                    //If the current character we're looking at is a number between 0 and 9,
                    if (input[i] >= '0' && input[i] <= '9')
                        //Keep track of how many numbers we've come across.
                        numOfNums++;
                }

                //If we haven't been given ten numbers,
                if (numOfNums !=10)
                    //Present an error.
                    return false;

                //While we still have characters to parse,
                for (int i = 0; i < input.Length; i++)
                {
                    //If the input is a number from 0 to 9, a (, a ), or a -,
                    if ((input[i] >= '0' && input[i] <= '9') || (input[i] == '(') || (input[i] == ')') || (input[i] == '-'))
                    {
                        //set that as a proper result.
                        validated = true;
                    }
                    //Otherwise,
                    else
                        //Present an error.
                        return false;
                }
                //Return the result.
                return validated;
            }
            //If the contact method is an email,
            else if (method == "email")
            {
                //initialize booleans to keep track of whether or not we see an @ or a . in the input.
                bool atSymbolPresent = false;
                bool extensionPresent = false;
                //Set the validation boolean to false as a sanity check.
                validated = false;
                //While we still have characters to parse,
                for (int i = 0; i < input.Length; i++)
                {
                    //If there is an @,
                    if (input[i] == '@')
                        //Keep track of the @ symbol.
                        atSymbolPresent = true;
                    //If there is a .,
                    if (input[i] == '.')
                        //Keep track of the ..
                        extensionPresent = true;
                }
                //If there is both an @ and a .,
                if (atSymbolPresent && extensionPresent)
                    //Return error-free.
                    return true;
                //Return whatever result we have.
                return validated;
            }
            //Return the validated boolean to ensure all paths return a value.
            return validated;
        }

        //Create a method to validate the 'preferred name' input.
        public bool validateName(string name)
        {
            //Initialize a boolean to keep track of the validation process.
            bool validated = false;
            //While we still have characters to parse,
            for (int i =0; i < name.Length; i++)
            {
                //If the current letter is a-z, A-Z, a -, a space, or a period,
                if ((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z') || (name[i] == '-') || (name[i] == ' ') || (name[i] == '.'))
                {
                    //Set the validated boolean to be true.
                    validated = true;
                }
                //If not,
                else
                    //Return an error.
                    return false;
            }
            //Return the result of the validation check.
            return validated;
        }
    }
}

