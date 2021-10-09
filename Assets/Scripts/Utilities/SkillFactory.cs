using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillFactory : MonoBehaviour
{
    public string inpSkillCode; // co dang: a,b,c|a,b,c (trong do: a = idElement, b= idEffect, c = idCategory)

    List<SkillCode> HandleStringInput()
    {
        List<SkillCode> lstSkillCode = new List<SkillCode>();
        string[] input = inpSkillCode.Split('|'); // tach cac skill don trong chuoi
        for (int i = 0; i < input.Length; i++)
        {
            string[] s = input[0].Split(',');// tach cac ma cua chieu
            int idEl, idEff, idCa;
            int.TryParse(s[0], out idEl);
            int.TryParse(s[1], out idEff);
            int.TryParse(s[2], out idCa);
            SkillCode skill = new SkillCode(idEl, idEff, idCa);
            lstSkillCode.Add(skill);
        }
        return lstSkillCode;
    }
    
}

public class SkillCode
{
    public SkillCode(int idElement, int idEffect, int idCategory)
    {
        this.idElement = idElement;
        this.idEffect = idEffect;
        this.idCategory = idCategory;
    }

    public int idElement;
    public int idEffect;
    public int idCategory;
}
