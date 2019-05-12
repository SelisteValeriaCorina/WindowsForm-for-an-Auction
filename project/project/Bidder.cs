﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    [Serializable]
    public class Bidder : IComparable<Bidder>
    {
        private object other;
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public float Amount;
        public Offer offer;

        public float Getamount()
        {
            return Amount;
        }
        public void setAmount(float _amount)
        {
            this.Amount = _amount;
            this.offer.setamount(_amount);
        }

        public Bidder(string name, string prename, float value)
        {
            offer = new Offer(value);
            this.LastName = name;
            this.FirstName = prename;
            this.Amount = value;
        }

        public Bidder()
        {

        }


        public int CompareTo(Bidder other)
        {
            if(this.Amount>=other.Amount)
            {
                return this.Amount.CompareTo(other.Amount);
            }
            return other.Amount.CompareTo(this.Amount);
            //throw new NotImplementedException();
        }
    }
}
