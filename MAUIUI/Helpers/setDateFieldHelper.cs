using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIUI.Helpers
{
    public class setDateFieldHelper
    {
        public static void setMaskedTextboxDate(DateTime? date, DatePicker maskedTextBox)
        {
            if (date != null && date.ToString().Length > 0 && date.ToString().Substring(0, date.ToString().IndexOf(" ")).Length < 10)
            {
                maskedTextBox.Date = (DateTime)date;
            }
            else if (date == null || date.ToString().Length < 1 )
            {
                maskedTextBox.IsVisible = false; 
            }
            else maskedTextBox.Date = (DateTime)date;
        }



        public static  string  ValidateUnnullableDate(DatePicker maskedTextBox, DateTime? minDate = null, DateTime? maxDate = null)
        {
            string dateFormat = "dd.MM.yyyy";
            DateTime parsedDate;
            DateTime minDateValue = minDate ?? DateTime.ParseExact("01.01.1800", dateFormat, CultureInfo.InvariantCulture);
            DateTime maxDateValue = maxDate ?? DateTime.Now;

            bool isValidFormat = DateTime.TryParseExact(maskedTextBox.Date.ToString(), dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);

            if (!isValidFormat || parsedDate < minDateValue || parsedDate > maxDateValue)
            {
                isValidFormat=false;
                // DisplayAlert("Invalid date. Please enter a valid date in the format: " + dateFormat, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox.Focus();
            }

            if (isValidFormat) return " Invalid date. Please enter a valid date in the format. " + dateFormat;
            else return null;
        }

        public static string ValidateNullableDate(DatePicker maskedTextBox, DateTime? minDate = null, DateTime? maxDate = null)
        {
            if (maskedTextBox.Date.ToString() == "  .  .")
            {
                return null;
            }
            string dateFormat = "dd.MM.yyyy";
            DateTime parsedDate;
            DateTime minDateValue = minDate ?? DateTime.ParseExact("01.01.1800", dateFormat, CultureInfo.InvariantCulture);
            DateTime maxDateValue = maxDate ?? DateTime.Now;

            bool isValidFormat = DateTime.TryParseExact(maskedTextBox.Date.ToString(), dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);

            if (!isValidFormat || parsedDate < minDateValue || parsedDate > maxDateValue)
            {
                isValidFormat = false;
                // MessageBox.Show(" Invalid date. Please enter a valid date in the format. " + dateFormat, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox.Focus();
            }
            if(isValidFormat) return " Invalid date. Please enter a valid date in the format. " + dateFormat;
            else return null;
        }


        public static string ValidateStartEndDate(DatePicker startDate, DatePicker EndDate)
        {
            if (startDate.Date!= null && EndDate.Date != null)
            {
                if (startDate.Date > EndDate.Date)
                {
                  //  MessageBox.Show("The end date must be after the start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    startDate.Focus();
                    return "The end date must be after the start date.";
                }
            }
            return null;
        }

        public static void setPicker(Picker picker, string text)
        {
            // Display only the first item
            //picker.Items.Clear();
            //picker.Items.Add(text);
            //picker.SelectedIndex = 0; // Select the first item

            picker.SelectedIndex = -1;
            foreach (var item in picker.Items)
            {
                if (text == item)
                {
                    picker.SelectedIndex = picker.Items.IndexOf(item);
                }
            }
        }


        public static string getPickerValue(Picker picker, string text)
        {
            // Display only the first item
            //picker.Items.Clear();
            //picker.Items.Add(text);
            //picker.SelectedIndex = 0; // Select the first item

            
                if (picker.SelectedIndex != -1)
                {
                    text=picker.SelectedItem.ToString();
                }
            return text;
        }
    }
}
