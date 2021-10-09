using System.Collections.Generic;
using UnityEngine;

public class Composite : BaseSkill
{
    public Composite(E_Elements element, E_Category category, BaseCharacter user) : base(element, category, user)
    {
    }

    protected List<BaseSkill> _children = new List<BaseSkill>();

    public override void Add(BaseSkill baseSkill)
    {
        this._children.Add(baseSkill);
    }

    public override void Remove(BaseSkill baseSkill)
    {
        this._children.Remove(baseSkill);
    }
}