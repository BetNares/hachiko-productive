using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HachickoProductive
{
    class Assignment : PriorityList, listinterface
    {
        //field
        string Judul;
        string Desc;
        int Deadline;
        int PriorityID;

        //method: assignID
        //method: write to database
        public string tulisApa { get
            {
                return this.Judul;
                return this.Desc;
            }
            set
            {
                this.Judul, this.Desc = value;
            }
        }
        public int Prior
        {
            get
            {
                return this.Deadline;
                return this.PriorityID;
            }
            set
            {
                this.PriorityID, this.Deadline = value;
            }
        }
    }
}
