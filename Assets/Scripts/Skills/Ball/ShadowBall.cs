using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBall : BaseSkill
{
    public ShadowBall(BaseCharacter user) : base(user)
    {
        idEffect =3;
    }

    public override void Excute(BaseCharacter baseEnemy)
    {
        base.Excute(baseEnemy);
        Effect(baseEnemy);
        Debug.Log("_ShadowBall: hut hp cua enemy");
        nextSkill?.Excute(baseEnemy);
    }

    /// <summary>
    /// effect: hut hp cua doi thu
    /// </summary>
    /// <param name="baseEnemy"></param>
    public void Effect(BaseCharacter baseEnemy)
    {
        baseEnemy.UpdateHP(-5);
        _user.UpdateHP(5);
    }

}
