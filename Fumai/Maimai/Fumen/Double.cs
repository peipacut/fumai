namespace Fumai.Maimai.Fumen;

public class Double : FumenObject
{
    public FumenObject Object1 { get; }
    public FumenObject Object2 { get; }

    public Double(FumenObject obj1, FumenObject obj2)
    {
        if ((obj1 as Double) != null || (obj2 as Double) != null)
            throw new InvalidFumenException("invalid construction, cannot combine other doubles in double");;
        
        Object1 = obj1;
        Object2 = obj2;
    }
}