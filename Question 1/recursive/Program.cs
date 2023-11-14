using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace recursive
{
    internal class Program
    {
       static List<Area> areas = new List<Area>();
        
        static void Main(string[] args)
        {
            //make list
            //use polymorphism to make sure the root parent has a null parentID
            areas.Add(new Area(1, "Continent"));
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
            //The first argument here is the index it should start at and second one the amount of lines
            AreasOut(0,1);
            //Just to stop it so we can see the output
            Console.ReadLine();
        }

        static void AreasOut(int id,int line)
        {
            //Get all the children that the id has
             List<Area> childern = (from row in areas where row.ParentID1 == id select row).ToList();
            //If it does not have childern we don't want to run it 
            if(childern.Count > 0)
            {
                //Loop through all of the children and get there chilren
                for (int j = 0; j < childern.Count; j++)
                {
                        for (int i = 0; i < line; i++)
                        {
                            Console.Write("-");
                        }
                        Console.Write(childern[j].Description1 + "\n");
                        //Send out the new parent id and increment line
                        AreasOut(childern[j].Id, line + 1);
                }
            }
        }
    }
    //Class so we can use a list of class area
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
        //The root parent has a null for parentID
        public Area(int id, string description )
        {
            this.id = id;
            Description = description;
         
        }

        public int Id { get => id; set => id = value; }
        public string Description1 { get => Description; set => Description = value; }
        public int ParentID1 { get => ParentID; set => ParentID = value; }
    }
}

