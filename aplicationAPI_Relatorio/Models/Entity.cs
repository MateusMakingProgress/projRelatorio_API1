using System.Text.Json.Serialization;

namespace aplicationAPI_Relatorio.Models
{
    public class Entity
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
