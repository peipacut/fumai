using Fumai.Maimai.Input;

namespace Fumai.Maimai.Fumen;

public class Slide : FumenObject
{
    public Button StartButton;
    public Button EndButton;
    public Curve CurveType;
    public int NoteValue;
    public int NoteQuantity;

    public enum Curve
    {
        Linear,
        CircleLeft,
        CircleRight,
        QQ,
    }
}