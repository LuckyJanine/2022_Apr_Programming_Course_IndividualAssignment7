using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Batch Class contains necessary information about each batch of 
/// a specific cell line lab-processed.
/// Each batch may have 1 or more than 1 vials of frozen cells but all vials (batch size)
/// within the same batch are treated, in theory, same way 
/// (cross-contamination should never be possible to happen among batches)
/// Each batch is assignment with an unique ID in context of its cooresponding cell line.
/// Each batch associates with one experiment in lab
/// thus there should be one lab journal exists
/// When the batch frozen/stored (cell banking or cyropreservation)
/// the App/registration keeps track of when this happened (frozenDate)
/// </summary>

namespace Assignment7
{
    internal class Batch
    {
        private string cellLine;

        private string batchNo;
        private DateTime frozenDate;
        private int batchSize;
        private string labJournal;

        // more ('biological') information of cell in a particular batch
        private int passage;

        #region CONSTRUCTORS
        public Batch(string line, string batchID, DateTime dt, int size, string journal, int p)
        {
            this.cellLine = line;
            
            this.batchNo = batchID;
            this.frozenDate = dt;
            this.batchSize = size;
            this.labJournal = journal;

            this.passage = p;
        }

        public Batch(string line) : this(line, string.Empty, DateTime.Today, 0, string.Empty, 0)
        {

        }

        public Batch() : this(string.Empty, string.Empty, DateTime.Today, 0, string.Empty, 0)
        {

        }
        #endregion

        #region PROPERTIES
        public string BatchNo
        {
            get { return this.batchNo; }
            set {
                if (value != string.Empty) {
                    this.batchNo = value;
                }
            }
        }

        public DateTime FrozenDate
        {
            get { return this.frozenDate; }
            set
            {
                this.frozenDate = value;
            }
        }

        public int BatchSize
        {
            get { return this.batchSize;}
            set { this.batchSize = value; }
        }

        public string LabJournal
        {
            get { return this.labJournal; }
            set { this.labJournal = value; }
        }

        public string CellLine
        {
            set { this.cellLine = value; }
            get { return this.cellLine; }
        }

        public int Passage
        {
            get { return this.passage; }
            set { this.passage = value; }
        }
        #endregion
    }
}
