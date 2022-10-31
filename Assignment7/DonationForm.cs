using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class DonationForm : Form
    {
        /// <summary>
        /// Every DonationForm starts with a 'new registration' (for adding) or an 'existing' one (for editing) - left upper corner
        /// followed by more details for users to fill up
        /// they are: date of operation, where is this (sampling) operation performed (eg. clinical center),
        /// what is the sample collected (type), what are SOP and ethical permit used.
        /// By closing this form, the newly filled information will be either added or updated in 
        /// the corresponding donor's donation.
        /// </summary>
        
        private Donation currentDonation;
        
        public DonationForm(ref Donation currDonation)
        {
            currentDonation = currDonation;
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            cmb_SampleType.DataSource = Enum.GetValues(typeof(SampleType));
            // cmb_SampleType.SelectedIndex = 0; not needed as donation constructors set this

            if (currentDonation.Donor == String.Empty)
            {
                grp_DonorID.Text = "New Registration";
            }
            else
            {
                grp_DonorID.Text = currentDonation.Donor;
                dtp_DonationDate.Value = currentDonation.DonationDate;
                txt_ClinicCenter.Text = currentDonation.ClinicCenter;
                cmb_SampleType.SelectedIndex = (int)currentDonation.StartingSample;
                txt_SOP.Text = currentDonation.SOP;
                txt_EthicalPerimit.Text = currentDonation.Permit;
                txt_Comment.Text = currentDonation.Comment;
            }
        }

        // if 'Cancel' button clicked
        // this.DonationForm will close
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // if 'add' button clicked
        // the above information will be added to the currentDonor object
        private void btn_addDonor_Click(object sender, EventArgs e)
        {
            currentDonation.DonationDate = dtp_DonationDate.Value;
            currentDonation.StartingSample = (SampleType)cmb_SampleType.SelectedIndex;
            bool success = getCenter() && getSOP() && getPermit();
            if (success)
            {
                currentDonation.Comment = txt_Comment.Text;
                this.Close();
            }
        }

        private bool getCenter()
        {
            if (txt_ClinicCenter.Text != String.Empty)
            {
                currentDonation.ClinicCenter = txt_ClinicCenter.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Please enter the clinic of the operation");
            }
            return false;
        }

        private bool getSOP()
        {
            if (txt_SOP.Text != String.Empty)
            {
                currentDonation.SOP = txt_SOP.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Please specify the SOP used");
            }
            return false;
        }

        private bool getPermit()
        {
            if(txt_EthicalPerimit.Text != String.Empty)
            {
                currentDonation.Permit = txt_EthicalPerimit.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Please specify the Ethical Permit");
            }
            return false;
        }
    }
}
