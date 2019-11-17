using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cards.Models
{
    public class CreateMoveRequest
    {
        public uint TileId { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
