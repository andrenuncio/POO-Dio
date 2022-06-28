namespace POO_Dio.src.Entities
{
    public abstract class Hero{
        public string name;

        public int level;

        public string heroType;
    
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        public override string ToString(){

            return $"Nome: {this.name} Nivel: {this.level} Tipo: {this.heroType}";

        }

        public virtual string Attack(){
            return $"{this.name} atacou com sua espada";
        }
    }
}