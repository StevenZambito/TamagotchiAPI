using System;

namespace TamagotchiAPI.Models
{
    public class Feeding
    {
        public int Id { get; set; }
        public DateTime WHen { get; set; }
        public int PetId { get; set; }
        public Pet TheAssociatedPet { get; set; }

    }
}