using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// CellLine Class contains information identifying a specific cell line 
/// which is derived from a particular individual
/// one cell line = one clone of one cell type from one specific donor
/// Each 'cell line' has a list of batches as same line could be generated in different batch (bench) work
/// with different passage number (indicating how long the cell has been cultured)
/// </summary>

namespace Assignment7
{
    internal class CellLine
    {
        private CellType type;
        private Clone clone;

        private string line = string.Empty;

        private BatchManager batchMgr;

        #region CONSTRUCTORS
        public CellLine(CellType type, Clone c)
        {
            this.type = type;
            this.clone = c;
            // concatenation of a type and a clone = a line
            this.batchMgr =  new BatchManager(line);
        }

        public CellLine() : this(CellType.FIBRO, Clone.I)
        {

        }
        #endregion

        #region PROPERTIES
        public CellType Type
        {
            get { return type; }
            set { this.type = value; }
        }

        public Clone Clone
        {
            get{ return clone; }
            set{ this.clone = value; }
        }

        public string Line
        {
            get { return "_" + this.type.ToString() + "_" + this.clone.ToString(); ; }
        }

        public int BatchSize
        {
            get { return batchMgr.BatchSize; }
        }
        #endregion

        #region OPERATIONS
        public bool addBatch(Batch batch)
        {
            if (batch != null)
            {
                batchMgr.addBatch(batch);
                return true;
            }
            return false;
        }
        #endregion
    }
}
