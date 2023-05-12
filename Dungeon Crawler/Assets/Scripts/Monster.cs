public class Monster : Inhabitant
{
    public Monster() : base(name)
    {

    }
    public string getData()
    {
        string s = this.name;
        s = s + "-" + this.hp + "/" + this.ac + "/" + this.damage;
        return s;
    }
}
