namespace Societies.Core.Models.Buildings.Abstract
{
    using Contracts;
    using System;

    public class Building : IBuilding
    {
        private readonly string address;
        private readonly string name;
        private int capacity;

        public Building(string name, string address, int capacity)
        {
            if (!this.AreFieldsValid(address, name))
            {
                throw new Exception();
            }

            this.address = address;
            this.name = name;
            this.capacity = capacity;
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            private set
            {
                
            }
        }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public bool AreFieldsValid(string address, string name)
        {
            var addressIsValid = this.IsAddressValid(address);
            var nameIsValid = this.IsNameValid(name);

            return addressIsValid && nameIsValid;
        }
        public bool IsAddressValid(string address)
        {
            return address.Length > 3 && address.Length < 225;
        }
        public bool IsNameValid(string name)
        {
            return name.Length > 1 && name.Length < 50;
        }
    }
}