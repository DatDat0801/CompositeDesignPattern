using System.Collections;
using UnityEngine;

public class FireSkill : BaseSkill
{

    
    public override void Excute(BaseCharacter baseCharacter)
    {
        base.Excute(baseCharacter);
        DoSkill(idEffect,baseCharacter);
    }

    void DoSkill(int idEffect,BaseCharacter baseCharacter)
    {
        switch (idEffect)
        {
            case 1:
                Effect1(baseCharacter);
                break;
            case 2:
                Effect2(baseCharacter);
                break;
        }
    }
    
    /// <summary>
    /// effect gay bong => enemy se mat mau theo thoi gian
    /// </summary>
    /// <param name="baseCharacter"></param>
    public void Effect1(BaseCharacter baseCharacter)
    {
        Ultilities.singleton.RunCoroutine(IE_Burn(baseCharacter,3,1,2));// gay chay 3 lan, moi lan cach nhau 1s gay dmg=2
    }

    IEnumerator IE_Burn(BaseCharacter baseCharacter,int time, float delay, int dmg)
    {
        for (int i = 0; i < time; i++)
        {
            baseCharacter.UpdateHP(-dmg);
            yield return new WaitForSeconds(delay);
        }
    }

    /// <summary>
    /// effect gay no nhiet, gay choang
    /// </summary>
    /// <param name="baseCharacter"></param>
    public void Effect2(BaseCharacter baseCharacter)
    {
        baseCharacter.UpdateHP(-5);
        baseCharacter.SetSpeed(0);// gay choang => khong di chuyen duoc
    }


    public FireSkill(E_Elements element, E_Category category, BaseCharacter user) : base(element, category, user)
    {
    }
}