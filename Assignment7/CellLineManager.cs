using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /// <summary>
    /// CellLineManager manages all cell lines derived from one particular donation
    /// </summary>
    internal class CellLineManager
    {
        private string donorID;
        private List<CellLine> cellLines;

        #region CONSTRUCTOR
        public CellLineManager(string donor)
        {
            this.donorID = donor;
            this.cellLines = new List<CellLine>();
        }
        #endregion

        #region PROPERTIES
        public int NumOfCellLines
        {
            get { return cellLines.Count; }
        }

        public string Donation
        {
            set { donorID = value; }
            get { return donorID; }
        }
        #endregion

        #region OPERATIONS
        // add a new cell line which is not already registered
        // returns true if not, then add
        // else, false
        public bool addLine(CellLine currCellLine)
        {
            if (!isRegisted(currCellLine))
            {
                cellLines.Add(currCellLine);
                return true;
            }
            else
            {
                return false;
            }
        }

        // to test if a particular cell line already registered 
        // returns true if yes
        // else, false
        private bool isRegisted(CellLine currCellLine)
        {
            string currLine = currCellLine.Line;
            foreach (CellLine cellLine in cellLines)
            {
                if (cellLine.Line.Equals(currLine))
                {
                    return true;
                }
            }
            return false;
        }

        private int findLineIndex(string line)
        {
            foreach (CellLine cellLine in cellLines)
            {
                if (cellLine.Line.Equals(line))
                {
                    return cellLines.IndexOf(cellLine);
                }
            }
            return -1;
        }

        // add a Batch to an existing cell line in the cell line manager
        public bool addBatch(Batch currBatch)
        {
            int index = findLineIndex(currBatch.CellLine);
            if (index != -1)
            {
                CellLine temp = cellLines[index];
                temp.addBatch(currBatch);
                cellLines[index] = temp;
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
