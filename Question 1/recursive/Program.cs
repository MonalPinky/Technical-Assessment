using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //make list
            List<Area> areas = new List<Area>();
            areas.Add(new Area(1, "Continent", 0));
            areas.Add(new Area(2, "Country", 1));
            areas.Add(new Area(3, "Province", 2));
            areas.Add(new Area(4, "City1", 3));
            areas.Add(new Area(5, "Suburb1", 6));
            areas.Add(new Area(6, "City2", 3));
            areas.Add(new Area(7, "Suburb2", 6));
            areas.Add(new Area(8, "Suburb3", 6));
            areas.Add(new Area(9, "Suburb4", 4));
            areas.Add(new Area(10, "House1", 7));
            areas.Add(new Area(11, "House3", 9));
            areas.Add(new Area(12, "House4", 8));
            areas.Add(new Area(13, "House5", 8));
            areas.Add(new Area(14, "House6", 7));

            //Call function
            ListPrint(areas);

        }
        static string ListPrint(List<Area> AreaList)
        {
            //Will work on this a bit latter. 
            string output = "";
            for (int i = 0; i < AreaList.Count; i++)
            {

            }

            return output;
        }
    }
    class Area
    {
        int id;
        string Description;
        int ParentID;

        public Area(int id, string description, int parentID)
        {
            this.id = id;
            Description = description;
            ParentID = parentID;
        }

        public int Id { get => id; set => id = value; }
        public string Description1 { get => Description; set => Description = value; }
        public int ParentID1 { get => ParentID; set => ParentID = value; }
    }
}

