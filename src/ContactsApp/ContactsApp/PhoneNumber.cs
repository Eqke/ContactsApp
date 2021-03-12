﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс для телефонного номера 
    /// </summary>
    public class PhoneNumber 
    {
        /// <summary>
        /// Переменная, хранящая номер.
        /// </summary>
        private string _number;

        /// <summary>
        /// Метод, который возвращает или задает номер.
        /// </summary>
        public string Number
        {
            get { return _number; }
            set
            {
                if ( !Regex.IsMatch(value, "[0-9]{11}") )
                {
                    throw new ArgumentException("Error: incorrected number. " +
                                                "Number have incorrected symbols");
                }
                if ( !Regex.IsMatch(value, "^[{7}]") )
                {
                    throw new ArgumentException("Error: incorrected number. " +
                                                "Number must started on 7");
                }
                if (value.Length > 11)
                {
                    throw new ArgumentException("Error: incorrected number. " +
                                                "Number can't have more then 11 symbols");
                }
                _number = value;
            }
        }

        /// <summary>
        /// Конструктор, принимающий на вход номер.
        /// </summary>
        /// <param name="number">Телефонный номер типа строки</param>
        public PhoneNumber(string number)
        {
            this.Number = number;
        }


    }
}
