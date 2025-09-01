using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace IT391_Crooks_Unit8
{
    public partial class Form1 : Form
    {
        //Initialize private strings for the lat and lon of the input address.
        private String strLatitude;
        private String strLongitude;
        public Form1()
        {
            //Initialize the form.
            InitializeComponent();
        }

        //Start a method to activate when the Submit button is clicked.
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Call the method for input validation, if the check is green,
            if (IsValidInput())
            {
                //Call the methods to set the longitude and latitude of the input address,
                SetLatLong();
                //And open Google Maps using the longitutde and latitude.
                OpenGoogleMaps();

                //Tell the user we opened Google Maps.
                txtInputMessage.Text = "We opened Google Maps to display that address.";
                //Set the "error" text to a pleasant green.
                txtInputMessage.ForeColor = Color.ForestGreen;
                //Force the back colour to update to be itself. For some reason you need this to change the fore-colour for a read-only text box in visual studio.
                txtInputMessage.BackColor = txtInputMessage.BackColor;
            }
        }
        //Start a method to execute when the Pin checkbox is clicked.
        private void cbxPin_CheckedChanged(object sender, EventArgs e)
        {
            //If the Pin checkbox is already checked,
            if (cbxPin.Checked == true)
            {

                //Uncheck the other checkboxes.
                cbxTerrain.Checked = false;
                cbxSatellite.Checked = false;
            }
        }

        //Start a method to execute when the terrain checkbox is clicked.
        private void cbxTerrain_CheckedChanged(object sender, EventArgs e)
        {
            //If the terrain checkbox is already checked,
            if (cbxTerrain.Checked == true)
            {
                //Uncheck the other checkboxes.
                cbxPin.Checked = false;
                cbxSatellite.Checked = false;
            }
        }

        //Start a method to execute when the Satellite checkbox is clicked.
        private void cbxSatellite_CheckedChanged(object sender, EventArgs e)
        {
            //If the satellite checkbox is checked,
            if (cbxSatellite.Checked == true)
            {
                //Uncheck the other check boxes.
                cbxTerrain.Checked = false;
                cbxPin.Checked = false;
            }
        }

        //Start a method to handle input validation.
        private Boolean IsValidInput()
        {
            //Initialize a variable to keep track of invalid inputs. It is false by default.
            bool validInput = false;
            //If any text box is empty,
            if (String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtCity.Text) || String.IsNullOrEmpty(txtState.Text) || String.IsNullOrEmpty(txtZipCode.Text))
            {
                //Set the error message font color to be red using the same trick as before.
                txtInputMessage.ForeColor = Color.Red;
                txtInputMessage.BackColor = txtInputMessage.BackColor;
                //Tell the user there is an empty text box.
                txtInputMessage.Text = "It looks like you have a blank field. Make sure to fill everything in.";
                //Return a no-go on input validation.
                return false;
            }
            if ((cbxSatellite.Checked == false) && (cbxTerrain.Checked == false) && (cbxPin.Checked == false))
            {
                //Set the error message font color to be red using the same trick as before.
                txtInputMessage.ForeColor = Color.Red;
                txtInputMessage.BackColor = txtInputMessage.BackColor;
                //Tell the user there is an empty text box.
                txtInputMessage.Text = "Please check a box for the output display.";
                return false;
            }
            //Check the Address text box for valid input.
            //For each letter in the Address text box,
            foreach (char letter in txtAddress.Text)
            {
                //If the letter is a valid character or a valid digit,
                if (Char.IsLetterOrDigit(letter))
                    //Set the input validation to be true.
                    validInput = true;
                //If it is not a letter or digit, but is a valid symbol as defined by USPS (the ascii value is for a '),
                else if (letter == '-' || letter == '/' || letter == '.' || letter == '\u0039' || letter == '#' || letter == '@' || letter == '%' || letter == '&' || letter == ' ')
                    //Set input validation to true.
                    validInput = true;
                //Otherwise,
                else
                    //Set input validation to false.
                    validInput = false;
            }
            //If the input isn't valid,
            if (validInput == false)
            {
                //Set the error message text box font color to red.
                txtInputMessage.ForeColor = Color.Red;
                txtInputMessage.BackColor = txtInputMessage.BackColor;
                //And tell the user the input is not valid.
                txtInputMessage.Text = "It seems like there's an invalid input for the address.";
                //Return a validation failure.
                return false;
            }

            //Check the City text box for valid input.
            //Reset the input validation.
            validInput = false;
            //For each letter in the city text box,
            foreach (char letter in txtCity.Text)
            {
                //If the letter is a valid letter,
                if (Char.IsLetter(letter))
                    //Set input validation to true.
                    validInput = true;
                //Otherwise, if it is a hyphen or space,
                else if (letter == '-' || letter == ' ')
                    //Set input validation to true.
                    validInput = true;
                //If it is none of the above,
                else
                    //Set input validation to false.
                    validInput = false;
            }

            //If input validation is false,
            if (validInput == false)
            {
                //Set the text color of the error message text box to red.
                txtInputMessage.ForeColor = Color.Red;
                txtInputMessage.BackColor = txtInputMessage.BackColor;
                //And tell the user there is an error in their city text box.
                txtInputMessage.Text = "It seems like there's an invalid input in the City field. Please ensure that special letters are their plain-text varients with no accents.";
                //Return an input validation failure.
                return false;
            }

            //Check the State Initial text box for valid input.
            //Reset the input validation.
            validInput = false;
            //If the state Initial is not two letters long,
            if (txtState.Text.Length != 2)
            {
                //Set the text color of the error message text box to red.
                txtInputMessage.ForeColor = Color.Red;
                txtInputMessage.BackColor = txtInputMessage.BackColor;
                //And tell the user there is an error in their initials text box.
                txtInputMessage.Text = "Please ensure the State's initials are exactly two letters.";
                //Return an input validation failure.
                return false;
            }

            //For each letter in the State's Initials text box,
            foreach (char letter in txtState.Text)
            {
                //If the letter is a valid letter,
                if (Char.IsLetter(letter))
                    //Set input validation to true.
                    validInput = true;
                //Otherwise,
                else
                {
                    //Set the text color of the error message text box to red.
                    txtInputMessage.ForeColor = Color.Red;
                    txtInputMessage.BackColor = txtInputMessage.BackColor;
                    //And tell the user there is an error in their initials text box.
                    txtInputMessage.Text = "Please ensure the State's initials are two letters. No other text is allowed.";
                    //Return an input validation failure.
                    return false;
                }
            }

            //Check the ZIP Code text box for valid input.
            //Reset the input validation.
            validInput = false;
            //For each letter in the Zip Code text box,
            foreach (char letter in txtZipCode.Text)
            {
                //If it is a valid number,
                if (Char.IsDigit(letter))
                    //set input validation to true,
                    validInput = true;
                //Otherwise, if it is a hyphen,
                else if (letter == '-')
                    //Set input validation to true.
                    validInput = true;
                //If it is none of the above,
                else
                    //Set input validation to true.
                    validInput = false;
            }

            //If the input is valid,
            if (validInput)
                //Return a success.
                return true;

            //Otherwise,
            else
            {
                //Set the text color of the error message text box to red.
                txtInputMessage.ForeColor = Color.Red;
                txtInputMessage.BackColor = txtInputMessage.BackColor;
                //Report something wrong with the ZIP code, as the code would have broken out if it was anything else.
                txtInputMessage.Text = "It seems there's something wrong with your ZIP code. Please ensure it contains only numbers and a hyphen.";
                //Return an input validation failure.
                return false;
            }
        }

        //Start a method to set the latitude and longitude using an address.
        private void SetLatLong()
        {
            //Format the input address into a single string separated by spaces.
            string address = txtAddress.Text + " " + txtCity.Text + " " + txtState.Text + " " + txtZipCode.Text;
            //initialize a gKey for the Google API.
            var gKey = "AIzaSyC6Gb_Dtv00W4QWtFoApeKvAH9Wr5z2Qw8";
            //Format a URI using the google API, the gKey, and the address.
            var requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?key={1}&address={0}&sensor=false", Uri.EscapeDataString(address), gKey);
            //store the request.
            var request = WebRequest.Create(requestUri);
            //Store Google's response.
            var response = request.GetResponse();
            //Load the response stream into an xdoc.
            var xdoc = XDocument.Load(response.GetResponseStream());
            //store the result.
            var result = xdoc.Element("GeocodeResponse").Element("result");
            //Keep track of the responding location element.
            var locationElement = result.Element("geometry").Element("location");

            //Set teh latitiude using the location Element.
            strLatitude = locationElement.Element("lat").ToString();
            //Cut off the qualifiers in the string.
            strLatitude = strLatitude.Substring(5);
            strLatitude = strLatitude.Substring(0, strLatitude.Length - 6);

            //Set the longitutde using the location element.
            strLongitude = locationElement.Element("lng").ToString();
            //Cut off the qualifiers in the string.
            strLongitude = strLongitude.Substring(5);
            strLongitude = strLongitude.Substring(0, strLongitude.Length - 6);
        }

        //Start a method to open Google Maps.
        private void OpenGoogleMaps()
        {
            //Initialize a URI (apparently if the URI is initialized in an if statement, the compiler gets mad because it doesn't trust me to code all paths.
            //These different URI's will output different Google Maps displays based on user choice.
            //This URI will default to the PIN display.
            var uri = string.Format("https://maps.google.com/maps/search/" + strLatitude + "," + strLongitude);
            //If the user selected the terrain readout,
            if (cbxTerrain.Checked == true)
                //Overwrite the URI to display the terrain readout.
                uri = string.Format("https://www.google.com/maps/@?api=1&map_action=map&center=" + strLatitude + "," + strLongitude + "&basemap=terrain");
            //If the user selected the Satellite readout,
            if (cbxSatellite.Checked == true)
                //Overwrite the URI to display the satellite readout.
                uri = string.Format("https://www.google.com/maps/@?api=1&map_action=map&center=" + strLatitude + "," + strLongitude + "&basemap=satellite");
            //Instantiate a new Proces Start Info stream.
            var psi = new System.Diagnostics.ProcessStartInfo();
            //set up the PSI for delivery
            psi.UseShellExecute = true;
            psi.FileName = uri;
            //Start the PSI using the chosen URI above.
            System.Diagnostics.Process.Start(psi);
        }
    }
}
