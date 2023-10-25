using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Client.Models
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Genre { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}