using System.Collections.Generic;

namespace LE_BildDatabase.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public byte[] PicData { get; set; }
        public string Name { get; set; }
        public List<Prices> Prices { get; set; }
    }
}