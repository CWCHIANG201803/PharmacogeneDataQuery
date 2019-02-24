using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PharmacogeneDataQuery
{
    // class DIR_Path_Entity compiles all possible path for access.
    class DIR_Path_Entity
    {
        public string DIR_PROJECT;
        public string DIR_DATA;
        public string DIR_DATA_INPUT;
        public string DIR_DATA_OUTPUT;
        public string DIR_DATA_SOURCE;

        public DIR_Path_Entity()
        {

            // constructor
            DIR_PROJECT = Environment.CurrentDirectory;
            //DIR_PROJECT = GetPath(System.AppDomain.CurrentDomain.BaseDirectory);
            // this is in 
            DIR_DATA = Path.Combine(Directory.GetParent(Directory.GetParent(DIR_PROJECT).ToString()).ToString() , "Data");
            DIR_DATA_INPUT = Path.Combine(DIR_DATA, "Input");
            DIR_DATA_OUTPUT = Path.Combine(DIR_DATA, "Output");
            DIR_DATA_SOURCE = Path.Combine(DIR_DATA, "Source");
        }

    }

}
