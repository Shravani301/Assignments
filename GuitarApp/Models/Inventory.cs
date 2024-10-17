using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    public class Inventory
    {
        private List<Guitar> guitars = new List<Guitar>();

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec)
        {
            guitars.Add(new Guitar(serialNumber, price, spec));
        }

        public Guitar GetGuitar(string serialNumber)
        {
            return guitars.FirstOrDefault(g => g.SerialNumber == serialNumber);
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            return guitars.Where(guitar => guitar.Spec.Matches(searchSpec)).ToList();
        }
    }
}
