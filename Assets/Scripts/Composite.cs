using System.Collections.Generic;
using UnityEngine;

public class Composite : BaseSkill
{
    public Composite(BaseCharacter user) : base(user)
    {
    }

    protected List<BaseSkill> _children = new List<BaseSkill>();

    // public override void Add(BaseSkill baseSkill)
    // {
    //     this._children.Add(baseSkill);
    // }

    // public override void Remove(BaseSkill baseSkill)
    // {
    //     this._children.Remove(baseSkill);
    // }
}