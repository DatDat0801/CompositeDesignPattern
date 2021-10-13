using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseSkill 
{
    public BaseSkill nextSkill;
    protected BaseCharacter _user;
    public int idSkill=1;
    public int idEffect=1;

    public BaseSkill(BaseCharacter user)
    {
        _user = user;
    }
    
    public void Add(BaseSkill baseSkill)
    {
        if(nextSkill==null)
        {
            nextSkill =baseSkill;
        }
        else{
            nextSkill.Add(baseSkill);
        }
    }
    public  void Remove(BaseSkill baseSkill)
    {
        if(nextSkill!=null) nextSkill=null;
    }
    public  virtual void Excute(BaseCharacter baseEnemy){}
}
