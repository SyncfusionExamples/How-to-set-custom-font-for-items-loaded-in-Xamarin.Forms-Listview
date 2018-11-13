﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfListViewSample
{
    public class Contacts : INotifyPropertyChanged
    {
        private string contactName;
        private string contactNumber;
        private ImageSource image;
        private string displayString;
        private Color color;
        private bool isLabelVisible1=true;

        public Contacts(string name, string number)
        {
            contactName = name;
            contactNumber = number;
            displayString = name[0].ToString();
        }

        public Contacts()
        {

        }

        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    this.RaisedOnPropertyChanged("ContactName");
                }
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }

        public ImageSource ContactImage
        {
            get { return this.image; }
            set
            {
                this.image = value;
                this.RaisedOnPropertyChanged("ContactImage");
            }
        }

        public string DisplayString
        {
            get { return displayString; }
            set
            {
                if (displayString != value)
                {
                    displayString = value;
                    this.RaisedOnPropertyChanged("DisplayString");
                }
            }
        }
        //public bool IsLabelVisible1
        //{
        //    get { return isLabelVisible1; }
        //    set
        //    {
        //        if (isLabelVisible1 != value)
        //        {
        //            isLabelVisible1 = value;
        //            this.RaisedOnPropertyChanged("IsLabelVisible1");
        //        }
        //    }
        //}

        public Color ContactColor
        {
            get { return color; }
            set
            {
                if (color != value)
                {
                    color = value;
                    this.RaisedOnPropertyChanged("ContactColor");
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }
}
