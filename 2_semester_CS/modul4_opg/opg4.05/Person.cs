using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace opg4._05
{
    public class Person
    {
        // Defining members:
        protected string _firstName, _lastName, _middleName, _CPRno;

        // Constructor med CPR# som parameter:
        public Person(string cpr)
        {
            this._CPRno = cpr;
        }
        // Constructor med CPR, fornavn, mellemnavn, efternavn og CPR# som parameter:
        public Person(string fornavn, string mellemnavn, string efternavn, string CPR)
        {
            this._firstName = fornavn;
            this._middleName = mellemnavn;
            this._lastName = efternavn;
            this._CPRno = CPR;
        }

        // firstName property
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        // lastName property
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        // middleName property
        public string middleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        // getName() metode
        public string getName()
        {
            string fuldtNavn = $"{_firstName} {_middleName} {_lastName}";
            return fuldtNavn;
        }
        // getSex() metode
        public string getSex()
        {
            string sex;
            int køn;
            køn = int.Parse(this._CPRno.Substring(9));
            if (køn % 2 == 0)
            {
                return sex = "Kvinde";
            } else
            {
                return sex = "Mand";
            }
        }
        // getBirthday() metode
        public DateTime getBirthday()
        {
            DateTime dato = DateTime.ParseExact(_CPRno.Substring(0, 6), "ddMMyy", CultureInfo.InvariantCulture);
            return dato;
        }
        // getAge() metode
        public Byte getAge()
        {
            DateTime datoNu = DateTime.Now;
            DateTime datoFødsel = DateTime.ParseExact(_CPRno.Substring(0, 6), "ddMMyy", CultureInfo.InvariantCulture);

            TimeSpan alder = datoNu.Subtract(datoFødsel);

            if (Math.Floor(alder.TotalDays / 365) < 0)
            {
                double år = Math.Floor(alder.TotalDays / 365) + 92;
                return Convert.ToByte(Math.Floor(år));
            }
            else if (Math.Floor(alder.TotalDays / 365) > 0)
            {
                double år = Math.Floor(alder.TotalDays / 365);
                return Convert.ToByte(Math.Floor(år));
            }
            return getAge();          
        }
    }
}
