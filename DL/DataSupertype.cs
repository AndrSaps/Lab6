using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DL
{
    public class DataSupertype
    {
        private LabContext context = null;
        public LabContext Context
        {
            get
            {
                return this.context = context ?? new LabContext();
            }
            set
            {
                this.context = value;
            }
        }
        public void SaveChanges()
        {
            this.Context.SaveChanges();
            this.Context = null;
        }
    }
}
