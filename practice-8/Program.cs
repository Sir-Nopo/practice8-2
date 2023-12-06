using System.Collections;
//MohammadReza Fattahi
Cow cow = new Cow();
public class Animal
{
    public DateTime Birthday { get; }

    public static readonly int MaxLife;

    public float Weight { get; set; }

    public bool Gendrt { get; set; }

    public string Name { get; set; }


    public float StressFactor()
    {
        return 0;
    }
    public int Life()
    {
        return 0;
    }
    public int TimeToDie()
    {
        return 0;

    }
    public float KillPriority()
    {
        return 0;

    }
    public int CostPerDay()
    {
        return 0;

    }
    public int ValuePerDay()
    {
        return 0;
    }
}

public class Cow : Animal, IEnumerable,IComparable
{
    public static int Number { get; set; }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
public class Sheep : Animal, IEnumerable,IComparable
{
    public static int Number { get; set; }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public class HealthParameter<T>
{
    public string Name { get; set; }

    public T Current { get; set; }

    public T Standart { get; set; }

    public float StressFactor()
    {
        return 0;
    }

    public override string ToString()
    {
        return base.ToString();
    }

}
public class CowParameter
{
    HealthParameter<string> parameters = new HealthParameter<string>();
    

}

public class Enviroment
{

}