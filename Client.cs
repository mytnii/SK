using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfClients
{
    internal class Client
    {
        #region Поля
        private string _lastName;         // Фамилия
        private string _firstName;        // Имя
        private string _patronymic;       // Отчество
        private int _serialPassport;      // Серия паспорта
        private int _numberPassport;      // Номер паспорта
        public List<Phone> phoneNumber;  // Номера телефонов
        #endregion

        #region Свойства
        public string LastName
        {
            get { return _lastName; }
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string Patronymic
        {
            get { return _patronymic; }
        }

        public int SerialPassport
        {
            get { return _serialPassport; }
        }

        public int NumberPassport
        {
            get { return _numberPassport; }
        }
        #endregion

        #region Конструкторы
        public Client
            (
            string lastName, string firstName,
            string patronymic, int serialPassport,
            int numberPassport
            )
        {
            this._lastName = lastName;
            this._firstName = firstName;
            this._patronymic= patronymic;
            this._serialPassport = serialPassport;
            this._numberPassport = numberPassport;
            phoneNumber= new List<Phone>();
        }
        #endregion
    }
}
