using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseSkill 
{
    protected E_Elements _element;
    protected E_Category _category;
    protected BaseCharacter _user;
    public int idSkill=1;
    public int idEffect=1;

    protected BaseSkill(E_Elements element, E_Category category,BaseCharacter user)
    {
        _element = element;
        _category = category;
        _user = user;
    }

    public void SetUp(E_Elements element,E_Category category)
    {
        _element = element;
        _category = category;
    }
    
    public virtual void Add(BaseSkill baseSkill){}
    public  virtual  void Remove(BaseSkill baseSkill){}
    public  virtual void Excute(BaseCharacter baseCharacter){}
}
