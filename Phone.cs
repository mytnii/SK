using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfClients
{
    internal class Phone
    {
        #region Поля
        private string _phonNum;        // Номер телефона
        #endregion

        #region Свойства
        public string PhoneNum
        {
            get { return _phonNum; }
            set { _phonNum = value; }
        }
        #endregion
    }
}
