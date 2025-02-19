using Modul5;

namespace Modul7;

public class MafiaDice : Dice
{
    public override void Roll()
    {
        base.Roll();
        if (GetEyes() != 6)
            base.Roll();
    }

}