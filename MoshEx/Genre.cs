using System.Collections.Generic;

namespace MoshEx
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Video> Videos { get; set; }
    }
}
