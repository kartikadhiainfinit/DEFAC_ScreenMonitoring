using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TietoVNCServerStarter
{
    public class PersistStartParameter
    {
        private VNCStartParameter _startParam;
        private SQLServerDAO startParamDAO = new SQLServerDAO();

        public PersistStartParameter(VNCStartParameter startParam)
        {
            this._startParam = startParam;
            PersistData();
        }

        public void PersistData()
        {
            if (startParamDAO.UserSIDExistInDB(_startParam.UserSID))
            {
                startParamDAO.UpdateStartParameter(_startParam);
            }
            else
            {
                startParamDAO.InsertStartParameter(_startParam);
            }
        }
    }
}
