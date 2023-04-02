using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    //FIO
    //Street
    //N_Home
    //N_Appart
    //N_Phone
    //N_HomePhone

    public class Person
    { 

        #region Свойства

        /// <summary>
        /// ФИО
        /// </summary>
        public string Name { get { return this.name; } set { this.name = value; } }

        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get { return this.street; } set { this.street = value; } }

        /// <summary>
        /// Номер Дома
        /// </summary>
        public string HouseNumber { get { return this.houseNumber; } set { this.houseNumber = value; } }

        /// <summary>
        /// Номер Квартиры
        /// </summary>
        public string FlatNumber{ get { return this.flatNumber; } set { this.flatNumber = value; } }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string MobilePhone { get { return this.mobilePhone; } set { this.mobilePhone = value; } }

        /// <summary>
        /// Номер домашнего телефона
        /// </summary>
        public string FlatPhone{ get { return this.flatPhone; } set { this.flatPhone = value; } }

        #endregion   

        #region Поля

        /// <summary>
        /// Поле "ФИО"
        /// </summary>
        private string name;

        /// <summary>
        /// Поле "Улица"
        /// </summary>
        private string street;

        /// <summary>
        /// Поле "Номер дома"
        /// </summary>
        private string houseNumber;

        /// <summary>
        /// Поле "Номер квартиры"
        /// </summary>
        private string flatNumber;

        /// <summary>
        /// Поле "Мобильный телефон"
        /// </summary>
        private string mobilePhone;

        /// <summary>
        /// Поле "Домашний телефон"
        /// </summary>
        private string flatPhone;

        #endregion

        #region Methods

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Street: {street}, House: {houseNumber}, Flat: {flatNumber}, Phone: {mobilePhone}, Flat Phone: {flatPhone}");
        }
        #endregion
    }
}
