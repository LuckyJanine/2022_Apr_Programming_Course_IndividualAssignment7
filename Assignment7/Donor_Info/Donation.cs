using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// Donation Class contains practical information of one donation of a donor
    /// each object is associated with one particular donation which has
    /// a donor, a clinics, a sample donated, 
    /// sampling procedure, an ethical permit and comment.
    /// </summary>
    public class Donation
    {
        private string donor;

        private DateTime donationDate;
        private string clinicCenter;
        private SampleType startingSample;
        private string sop;
        private string permit;
        private string comment;

        private CellLineManager derivedCellLines;

        #region CONSTRUCTOR
        public Donation(string donor)
        {
            this.donor = donor;
            this.donationDate = DateTime.Today;
            this.clinicCenter = String.Empty;
            this.startingSample = SampleType.Skin_Biopsy;
            this.sop = string.Empty;
            this.permit = string.Empty;
            this.comment = string.Empty;

            derivedCellLines = new CellLineManager(donor);
        }
        #endregion

        #region PROPERTIES
        public string Donor
        {
            get { return this.donor; }
            set { this.donor = value; }
        }

        public DateTime DonationDate
        {
            get { return this.donationDate; }
            set { this.donationDate = value; }
        }

        public string ClinicCenter
        {
            get { return this.clinicCenter; }
            set { this.clinicCenter = value; }
        }

        internal SampleType StartingSample
        {
            get { return this.startingSample; }
            set { this.startingSample = value; }
        }

        public int NumOfCellLines
        {
            get { return this.derivedCellLines.NumOfCellLines;}
        }

        public string SOP
        {
            get { return this.sop; }
            set { this.sop = value; }
        }

        public string Permit
        {
            get { return this.permit; }
            set { this.permit = value; }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public string donorID
        {
            set { derivedCellLines.Donation = value; }
        }
        #endregion

        #region OPERATIONS
        internal bool addCellLine(CellLine currLine)
        {
            if (currLine != null && derivedCellLines.addLine(currLine))
            {
                return true;
            }
            return false;
        }

        // add a Batch to an existing cell line in the cell line manager
        internal bool addBatch(Batch currBatch)
        {
            if (derivedCellLines.addBatch(currBatch))
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
