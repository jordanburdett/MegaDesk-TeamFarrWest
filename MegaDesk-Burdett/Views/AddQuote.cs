using MegaDesk_Burdett.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Burdett
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainMenuView = (MainMenu)this.Tag;
            this.Close();
            mainMenuView.Show();
        }

        private void ValidateCustomerName(object sender, CancelEventArgs e)
        {
            if (CustomerNameTextField.TextLength > 0)
            {
                CustomerNameErrorLabel.Text = "Looks Good!";
                CustomerNameErrorLabel.ForeColor = Color.Green;
            }
            else
            {
                CustomerNameErrorLabel.Text = "This field is required..";
                CustomerNameErrorLabel.ForeColor = Color.Red;
            }
        }

        private void ValidateDeskWidth(object sender, CancelEventArgs e)
        {
            if (DeskWidthInputField.Value < 24 || DeskWidthInputField.Value > 96)
            {
                DeskWidthErrorLabel.Text = "Value must be between 24 - 96 inches!";
                DeskWidthErrorLabel.ForeColor = Color.Red;
            }
            else
            {
                DeskWidthErrorLabel.Text = "Perfect!";
                DeskWidthErrorLabel.ForeColor = Color.Green;
            }
        }

        private void ValidateDeskDepth(object sender, CancelEventArgs e)
        {
            if (DeskDepthInputField.Value < 12 || DeskDepthInputField.Value > 48)
            {
                DeskDepthErrorLabel.Text = "Value must be between 12 - 48 inches!";
                DeskDepthErrorLabel.ForeColor = Color.Red;
            }
            else
            {
                DeskDepthErrorLabel.Text = "Perfect!";
                DeskDepthErrorLabel.ForeColor = Color.Green;
            }
        }

        private void ValidateNumberOfDrawers(object sender, CancelEventArgs e)
        {
            if (NumberOfDrawersTextField.Value < 0 || NumberOfDrawersTextField.Value > 7)
            {
                NumberOfDrawersErrorLabel.Text = "Value must be between 24 - 48 inches!";
                NumberOfDrawersErrorLabel.ForeColor = Color.Red;
            }
            else
            {
                NumberOfDrawersErrorLabel.Text = "Perfect!";
                NumberOfDrawersErrorLabel.ForeColor = Color.Green;
            }
        }

        private void DesktopMaterialValidation(object sender, CancelEventArgs e)
        {
            isValidDesktopMaterial();
        }

        private bool isValidDesktopMaterial()
        {
            switch (DesktopMaterialTextField.Text.ToLower())
            {
                case "laminate":
                    DeskTopMaterialErrorLabel.ForeColor = Color.Green;
                    break;
                case "oak":
                    DeskTopMaterialErrorLabel.ForeColor = Color.Green;
                    break;
                case "rosewood":
                    DeskTopMaterialErrorLabel.ForeColor = Color.Green;
                    break;
                case "veneer":
                    DeskTopMaterialErrorLabel.ForeColor = Color.Green;
                    break;
                case "pine":
                    DeskTopMaterialErrorLabel.ForeColor = Color.Green;
                    break;
                default:
                    DeskTopMaterialErrorLabel.ForeColor = Color.Red;
                    return false;  
            }

            return true;
        }

        private void DeliveryOptionsValidation(object sender, CancelEventArgs e)
        {
            isValidDeliveryOption();
        }

        private bool isValidDeliveryOption()
        {
            
                switch (DeliveryOptionsTextField.Text.ToLower())
                {
                    case "3":
                        DeliveryOptionsErrorLabel.ForeColor = Color.Green;
                        break;
                    case "5":
                        DeliveryOptionsErrorLabel.ForeColor = Color.Green;
                        break;
                    case "7":
                        DeliveryOptionsErrorLabel.ForeColor = Color.Green;
                        break;
                    default:
                    DeliveryOptionsErrorLabel.ForeColor = Color.Red;
                    return false;
                }
            

            return true;
            
        }

        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextField.Text.Length <= 0
                || DeskWidthInputField.Value < 24 || DeskWidthInputField.Value > 96
                || DeskDepthInputField.Value < 12 || DeskDepthInputField.Value > 48
                || NumberOfDrawersTextField.Value < 0 || NumberOfDrawersTextField.Value > 7
                || !isValidDesktopMaterial()
                || !isValidDeliveryOption())
            {

                return;
            }

            MaterialType materialType = MaterialType.Laminate;

            switch (DesktopMaterialTextField.Text.ToLower())
            {
                case "laminate":
                    materialType = MaterialType.Laminate;
                    break;
                case "oak":
                    materialType = MaterialType.Oak;
                    break;
                case "rosewood":
                    materialType = MaterialType.Rosewood;
                    break;
                case "veneer":
                    materialType = MaterialType.Veneer;
                    break;
                case "pine":
                    materialType = MaterialType.Pine;
                    break;
            }

            DeliveryOptions deliveryOptions = DeliveryOptions.Five;

            switch (DeliveryOptionsTextField.Text.ToLower())
            {
                case "3":
                    deliveryOptions = DeliveryOptions.Three;
                    break;
                case "5":
                    deliveryOptions = DeliveryOptions.Five;
                    break;
                case "7":
                    deliveryOptions = DeliveryOptions.Seven;
                    break;
            }

            Desk newDesk = new Desk((int)DeskWidthInputField.Value, (int)DeskDepthInputField.Value, (int)NumberOfDrawersTextField.Value, materialType);
            DeskQuote newQuote = new DeskQuote(newDesk, CustomerNameTextField.Text, deliveryOptions);

            // create new view
            DisplayQuotes displayQuoteView = new DisplayQuotes();
            displayQuoteView.Tag = this;
            displayQuoteView.showQuote(newQuote);

            // hide this form
            this.Hide();

            // show the other form
            displayQuoteView.Show();
        }
    }
}
