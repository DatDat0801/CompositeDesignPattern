using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBall : BaseSkill
{
    public LightBall(BaseCharacter user) : base(user)
    {
        idEffect=2;
    }

    public override void Excute(BaseCharacter baseEnemy)
    {
        base.Excute(baseEnemy);
        Effect(baseEnemy);
        Debug.Log("_LightBall: giam toc do cua enemy");
        nextSkill?.Excute(baseEnemy);
    }

    /// <summary>
    /// effect ban tia sang, gay choang
    /// </summary>
    /// <param name="baseEnemy"></param>
    public void Effect(BaseCharacter baseEnemy)
    {
        baseEnemy.SetSpeed(0);// gay choang => khong di chuyen duoc
    }
}
