using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Burdett.Models
{
    public class Desk
    {
        public int width {  get; set; }
        public int depth {  get; set; }
        public int numOfDrawers { get; set; }
        public MaterialType DesktopMaterial {  get; set; }

        public Desk(int width, int depth, int numOfDrawers, MaterialType DesktopMaterial) 
        {
            this.width = width;
            this.depth = depth; 
            this.numOfDrawers = numOfDrawers;
            this.DesktopMaterial = DesktopMaterial;
        }
    }


    public enum MaterialType
    { 
        Laminate, Oak, Rosewood, Veneer, Pine
    }
}
