using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : BaseSkill
{
    public FireBall(BaseCharacter user) : base(user)
    {
        idEffect=1;
    }

    //effect gay bong => enemy se mat mau theo thoi gian
    public override void Excute(BaseCharacter baseEnemy)
    {
        base.Excute(baseEnemy);
        Ultilities.singleton.RunCoroutine(IE_Burn(baseEnemy, 3, 1, 2));// gay chay 3 lan, moi lan cach nhau 1s gay dmg=2
        Debug.Log("_FireBall: Gay bong cho muc tieu");
        nextSkill?.Excute(baseEnemy);
    }

    IEnumerator IE_Burn(BaseCharacter baseEnemy, int time, float delay, int dmg)
    {
        for (int i = 0; i < time; i++)
        {
            baseEnemy.UpdateHP(-dmg);
            yield return new WaitForSeconds(delay);
        }
    }
}
