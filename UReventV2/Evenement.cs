using System;
namespace UReventV2
{
    public class Evenement
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Tags { get; set; }
        public string Start { get; set; }
        public string End { get; set; }

        public Evenement(string id, string name, string adress, string description, string price, string tags, string start, string end)
        {
            this.Id = id;
            this.Name = name;
            this.Adress = adress;
            this.Description = description;
            this.Price = price;
            this.Tags = tags;
            this.Start = start;
            this.End = end;
        }
    }
}
