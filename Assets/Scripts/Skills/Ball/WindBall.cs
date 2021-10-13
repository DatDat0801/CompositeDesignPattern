using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBall : BaseSkill
{
    public WindBall(BaseCharacter user) : base(user)
    {
        idEffect=5;
    }

    public override void Excute(BaseCharacter baseEnemy)
    {
        base.Excute(baseEnemy);
        Effect(baseEnemy);
        Debug.Log("_WindBall: day doi thu ve phia sau");
        nextSkill?.Excute(baseEnemy);
    }
    /// <summary>
    /// effect day doi thu lui lai phia sau
    /// </summary>
    /// <param name="baseEnemy"></param>
    public void Effect(BaseCharacter baseEnemy)
    {
        Rigidbody2D rb = baseEnemy.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * 3f;
    }
}
