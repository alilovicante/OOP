using System;
using System.Collections.Generic;
using System.Text;

namespace lv2
{
    public class Contact
    {
        private string name;
        private string surname;
        private string phone;
        private string email;

        public Contact(string name,string surname,string phone,string email)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.email = email;
        }
        public string Ime
        {
            get { return name; }
            set { this.name = value; }
        }
        public string Prezime
        {
            get { return surname; }
            set { this.surname = value; }
        }
        public string Broj
        {
            get { return phone; }
            set { this.phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }
        public string Ispis()
        {
            return ($"Ime: {name}\nPrezime: {surname}\nPhone: {phone}\nE-mail: {email}");
        }
    }
}
