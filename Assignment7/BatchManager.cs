using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// BatchManager Class contains a list of Bacth objects
/// </summary>
namespace Assignment7
{
    internal class BatchManager
    {
        private string cellLine;
        private List<Batch> batchManager;
        private int[] IDs = new int[30]; 
        // assuming a number of 30 batches is allowed for each cell line
        // (in reality, way more than enough for stem cell lines, generally speaking)

        #region CONSTRUCTOR
        public BatchManager(string currCellLine)
        {
            this.cellLine = currCellLine;
            batchManager = new List<Batch>();
        }
        #endregion

        #region PROPERTIES
  
        public int BatchSize
        {
            get { return batchManager.Count; }
        }

        public string CellLine
        {
            get { return cellLine; }
        }
        #endregion

        #region OPERATIONS
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
        
        public bool addBatch(Batch batch)
        {
            int batchID = getID();
            if(batch != null && batchID != -1)
            {
                batch.BatchNo = "batch #" + batchID.ToString("00");
                batchManager.Add(batch);
                return true;
            }
            return false;
        }
        #endregion
    }
}
