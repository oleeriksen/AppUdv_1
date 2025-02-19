using Modul5;
namespace Modul7;

public class DiceCup
{
    private List<Dice> mDices;

    public DiceCup(int size = 5)
    {
        mDices = new();
        foreach (int value in Enumerable.Range(1,size-1))
            mDices.Add( new Dice());
        mDices.Add( new MafiaDice());
    }

    public void Shake()
    {
        foreach (Dice d in mDices)
            d.Roll();
    }

    public int[] GetEyes()
    {
        int[] res = new int[mDices.Count];
        for (int i = 0; i < res.Length; i++)
            res[i] = mDices[i].GetEyes();
        return res;
        //return mDices.Select(d => d.GetEyes()).ToArray();
    }
}