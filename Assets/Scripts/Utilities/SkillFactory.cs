using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFactory : Singleton<SkillFactory>
{
    public List<E_Skill> skills;

    #region  for Demo
    public BaseSkill baseSkill;
    public BaseCharacter basePlayer;
    public BaseCharacter baseEnemy;
    public bool doSkill;
    #endregion
    void Update()
    {
        if (doSkill)
        {
            baseSkill = GenTreeSkill(skills, basePlayer);
            baseSkill.Excute(baseEnemy);
            doSkill = false;
        }
    }
    public BaseSkill GenTreeSkill(List<E_Skill> lstSkill, BaseCharacter playerBase)
    {
        BaseSkill bs = GetSkill(lstSkill[0], playerBase);
        for (int i = 1; i < lstSkill.Count; i++)
        {
            BaseSkill tmp = GetSkill(lstSkill[i], playerBase);
            bs.Add(tmp);
        }
        return bs;
    }


    BaseSkill GetSkill(E_Skill e_Skill, BaseCharacter playerBase)
    {
        switch (e_Skill)
        {
            case E_Skill.fireBall:
                return new FireBall(playerBase);
            case E_Skill.lightBall:
                return new LightBall(playerBase);
            case E_Skill.shadowBall:
                return new ShadowBall(playerBase);
            case E_Skill.waterBall:
                return new WaterBall(playerBase);
            case E_Skill.windBall:
                return new WindBall(playerBase);
        }
        return null;
    }
}
