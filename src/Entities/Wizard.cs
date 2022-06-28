namespace POO_Dio.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {

        }

        public override string Attack()
        {
            return $"{this.name} atacou com sua magia";
        }

        public string Attack(int bonus)
        {
            return $"{this.name} atacou com sua magia com bonus de ataque: {bonus}";
        }
    }
}