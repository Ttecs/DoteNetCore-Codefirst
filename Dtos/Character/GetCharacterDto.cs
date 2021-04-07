using dotnet_rpg.Models;

namespace dotnet_rpg.Dtos.Character
{
    public class GetCharacterDto
    {
        
        public int Id { get; set; }
        public string Name { get; set; }="frodo";
        public int Hitpoints { get; set; }=100;
        public int strenghth { get; set; }=10;

        public RpgClass Class { get; set; }=RpgClass.Knight;
    }
}