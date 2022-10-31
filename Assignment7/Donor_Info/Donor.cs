using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// each Donor when donating one material has an ID of this oepration
    /// biological gender should be kept as a record, so should the age range
    /// and has a Donation.
    /// </summary>
    
    public class Donor
    {
   
        private string donorID;
        private string gender;
        private AgeRange age;

        private Donation donation;

        #region CONSTRUCTOR
        public Donor(string donor)
        {
            this.donorID = donor;
            this.gender = string.Empty;
            this.age = AgeRange.Adult;

            this.donation = new Donation(donor);
        }
        #endregion

        #region PROPERTIES
        public string DonorID
        {
            get { return donorID; }
            set { this.donorID = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { this.gender = value; }
        }

        public AgeRange Age
        {
            get { return age; }
            set { this.age = value; }
        }

        public Donation Donation
        {
            get { return donation; }
        }
        #endregion
    }
}
