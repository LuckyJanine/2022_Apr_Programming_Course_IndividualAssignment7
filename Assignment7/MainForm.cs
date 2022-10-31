namespace Assignment7
{
    /// <summary>
    /// mainForm panel contains four parts: 
    /// 1) Donor: 'gender' and 'age range' as inputs, and one button 'add' initialize one donation Form for more input
    ///    By closing the donatoin Form, one donor (donation event) will be added to 'donorList' (a list of donors)
    /// 2) listview: showing donor elements in donorList
    /// 3) Cell line: DonorID, cellType, Clone#, CellLine(full_information)
    /// 4) Batch: passage, frozenDate, batchSize, Jounral.
    /// </summary>
    public partial class MainForm : Form
    {
        private Batch currBatch;
        private CellLine currLine;
        private Donor currDonor;
        private List<Donor> donorList = new List<Donor>();
        // assumed max capacility: 50.
        private int[] IDs = new int[50]; // keeping track of surrogate keys used
        
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            cmb_AgeRange.DataSource = Enum.GetValues(typeof(AgeRange));
            cmb_AgeRange.SelectedIndex = 5;
            cmb_CellType.DataSource = Enum.GetValues(typeof(CellType));
            cmb_Clone.DataSource = Enum.GetValues(typeof(Clone));
            disableBatchGUI();
        }

        // will be activated (called) only when a particular donor selected
        // e.g. when this event 'btn_deriveCells_Click' happens
        private void initializeCellGUI()
        {
            txt_DonorID.Enabled = true;
            cmb_CellType.Enabled = true;
            cmb_Clone.Enabled = true;

            txt_CellLineID.Enabled = true;

            cmb_CellType.SelectedIndex = 0;
            cmb_Clone.SelectedIndex = 0;
            txt_Passage.Text = String.Empty;
            txt_CellLineID.Text = String.Empty;

            dtp_FrozenDate.Value = DateTime.Today;
            txt_NoVails.Text = String.Empty;
            txt_LabJournal.Text = String.Empty;

            btn_registerLine.Enabled = true;
        }

        // will be activated (called) when a particlar cell line registered first
        private void initializeBatchGUI()
        {
            txt_Passage.Enabled = true;
            dtp_FrozenDate.Enabled = true;
            txt_NoVails.Enabled = true;
            txt_LabJournal.Enabled = true;

            btn_registerBatch.Enabled = true;
        }

        // will be disactivated (called) when the Batch has been registered
        private void disableBatchGUI()
        {
            txt_DonorID.Enabled = false;
            cmb_CellType.Enabled = false;
            cmb_Clone.Enabled = false;

            txt_CellLineID.Enabled = false;

            txt_Passage.Enabled = false;
            dtp_FrozenDate.Enabled = false;
            txt_NoVails.Enabled = false;
            txt_LabJournal.Enabled = false;

            btn_registerLine.Enabled = false;
            btn_registerBatch.Enabled = false;
        }


        // update list view of registered donors
        private void updateGUI()
        {
            lstv_DonorList.Items.Clear();
            foreach (Donor donor in donorList)
            {
                if(donor != null)
                {
                    Donation temp = donor.Donation;
                    ListViewItem item = new ListViewItem(donor.DonorID);
                    item.SubItems.Add(donor.Gender);
                    item.SubItems.Add(donor.Age.ToString());
                    item.SubItems.Add(temp.StartingSample.ToString());
                    item.SubItems.Add(temp.NumOfCellLines.ToString()) ;
                    lstv_DonorList.Items.Add(item);
                }
            }
        }

        // keep track of integers used as IDs
        private int getID()
        {
            for(int i = 0; i < IDs.Length; i++)
            {
                if (IDs[i] == 0)
                {
                    IDs[i] = 1;
                    return i;
                }
            }
            return -1;
        }

        // if 'add more' button clicked
        // a DonationForm will show up
        private void btn_addMore_Click(object sender, EventArgs e)
        {
            // 'create' a new donor object
            currDonor = new Donor("");
            Donation temp = currDonor.Donation;
            if (txt_Gender.Text != String.Empty)
            {
                currDonor.Gender = txt_Gender.Text;
                currDonor.Age = (AgeRange)cmb_AgeRange.SelectedIndex;
                Form donationForm = new DonationForm(ref temp);
                donationForm.FormClosing += DonationForm_add_closing;
                donationForm.ShowDialog();
                txt_Gender.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Please specify the donor's (biological) gender");
            }
        }

        // if 'edit' button clicked
        // a DonationForm will also show up
        // with the selected (existing) information pre-filled
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (lstv_DonorList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please click on the donation that needs to be edited");
                return;
            }
            else
            {
                int index = lstv_DonorList.Items.IndexOf(lstv_DonorList.SelectedItems[0]);
                currDonor = donorList[index];
                Donation temp = currDonor.Donation;
                // update gender and age info to GUI
                txt_Gender.Text = currDonor.Gender;
                cmb_AgeRange.SelectedIndex = (int)currDonor.Age;

                // create a new DonationForm object
                Form DonationForm = new DonationForm(ref temp);
                DonationForm.FormClosing += DonationForm_edit_closing;
                DonationForm.ShowDialog();
            }
        }

        private void DonationForm_add_closing(object sender, FormClosingEventArgs e)
        {
            // assign ID when added to the donorList
            if (currDonor.Donation.ClinicCenter != String.Empty)
            {
                int id = getID();
                if (id != -1)
                {
                    string currID = "D" + id.ToString("00");
                    currDonor.DonorID = currID; // set donors ID
                    currDonor.Donation.Donor = currID; // set donations donor ID
                    currDonor.Donation.donorID = currID; // set derived cell lines managers donor ID
                    donorList.Add(currDonor);
                    updateGUI();
                }
                else
                {
                    MessageBox.Show("the App runs out of capaclity with surrogate key");
                }
            }
        }

        private void DonationForm_edit_closing(object sender, FormClosingEventArgs e)
        {
            int index = lstv_DonorList.SelectedIndices[0];
            currDonor.Gender = txt_Gender.Text;
            currDonor.Age = (AgeRange)cmb_AgeRange.SelectedValue;
            donorList[index] = currDonor;
            updateGUI();
        }

        // every donor has rights to drop out her or his donations
        // system must delete all data related
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lstv_DonorList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please click on the donation that needs to be deleted");
                return;
            }
            else
            {
                int index = lstv_DonorList.SelectedIndices[0];
                donorList.RemoveAt(index);
                updateGUI();
            }
        }

        private void btn_deriveCells_Click(object sender, EventArgs e)
        {
            // when 'derive cell line' button clicked
            // 'cellline register buttons' and others activated
            if (lstv_DonorList.SelectedItems.Count != 1 || lstv_DonorList.Items.Count == 0)
            {
                MessageBox.Show("Please select one or register a donation material to derive cells");
                return;
            }
            else
            {
                int index = lstv_DonorList.Items.IndexOf(lstv_DonorList.SelectedItems[0]);
                if (index != -1)
                {
                    currDonor = donorList[index];
                    // update cell part of GUI, fill up donor ID information automatically
                    txt_DonorID.Text = currDonor.DonorID;
                    // create objects of CellLine and Batch
                    currLine = new CellLine();
                    currBatch = new Batch();
                    initializeCellGUI();
                }
                else // if index == -1
                {
                    MessageBox.Show("donation 'database' is empty. Please register starting material first.");
                }
            }
        }

        // by clicking on the CellLineID textbox 
        // the user has a chance to 'double check' before click 'register button'
        // 'register button' will create Line and Batch objects afterwards
        private void txt_CellLineID_Click(object sender, EventArgs e)
        {
            string donorID = currDonor.DonorID;
            string cellType = cmb_CellType.SelectedItem.ToString();
            string cellClone = cmb_Clone.SelectedItem.ToString();

            if (donorID != string.Empty)
            {
                txt_CellLineID.Text = donorID + "_" + cellType + "_" + cellClone;
            }
        }

        private CellLine getTypeClone()
        {
            CellType currType = (CellType)cmb_CellType.SelectedIndex;
            Clone currClone = (Clone)cmb_Clone.SelectedIndex;
            currLine.Type = currType;
            currLine.Clone = currClone;
            return currLine;
        }

        // by clicking on the resigerLine button
        // App creates a cellLine object
        // add it to the donation's CellLineManager
        private void btn_registerLine_Click(object sender, EventArgs e)
        {
            currLine = getTypeClone();
            
            if (currDonor.Donation.addCellLine(currLine))
            {
                updateGUI();
                string msg = string.Format("The cell line {0} added successfully", currLine.Line);
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("The cell line exists already");
            }
            initializeBatchGUI();
        }

        // by clicking on the registerBatch button
        // App creates a Batch object
        // add it to the corresponding CellLine's BatchManager
        private void btn_registerBatch_Click(object sender, EventArgs e)
        {
            int passage = 0;
            int NumOfVials = 0;
            if (currLine.Line != String.Empty)
            {
                currBatch.CellLine = currLine.Line;
                currBatch.FrozenDate = dtp_FrozenDate.Value;
                if (getPassage() && getBatchSize() && getJournal())
                {
                    if (currDonor.Donation.addBatch(currBatch))
                    {
                        MessageBox.Show("Batch has been added");
                        // disable this part of GUI after each batch registration finished
                        disableBatchGUI();
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong when reading inputs");
                }
            }
            else
            {
                MessageBox.Show("Please specify a cell line before adding a batch");
            }
        }

        private bool getPassage()
        {
            int passage = 0;
            if(int.TryParse(txt_Passage.Text, out passage))
            {
                currBatch.Passage = passage;
                return true;
            }
            else
            {
                MessageBox.Show("Please indicate the Passage Number, >=0");
            }
            return false;
        }

        private bool getBatchSize()
        {
            int batchSize = 0;
            if (int.TryParse(txt_NoVails.Text, out batchSize))
            {
                currBatch.BatchSize = batchSize;
                return true;
            }
            else
            {
                MessageBox.Show("Please indicate the size of the batch, >0");
            }
            return false;
        }

        private bool getJournal()
        {
            if (txt_LabJournal.Text != String.Empty)
            {
                currBatch.LabJournal = txt_LabJournal.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Please specify the lab journal used");
            }
            return false;
        }
    }
}