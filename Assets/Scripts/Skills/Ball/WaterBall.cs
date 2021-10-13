using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBall : BaseSkill
{
    public WaterBall(BaseCharacter user) : base(user)
    {
        idEffect=4;
    }

    public override void Excute(BaseCharacter baseEnemy)
    {
        base.Excute(baseEnemy);
        Effect(baseEnemy);
        Debug.Log("_waterBall: phuc hoi hp cho player");
        nextSkill?.Excute(baseEnemy);
    }

    /// <summary>
    /// effect hoi phuc hp
    /// </summary>
    /// <param name="baseEnemy"></param>
    public void Effect(BaseCharacter baseEnemy)
    {
        _user.UpdateHP(10);
    }
}
