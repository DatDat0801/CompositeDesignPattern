using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour
{
    [SerializeField] protected CharInfo _charInfo;
    private bool canUpHP = true;

    public bool CanUpHp
    {
        get => canUpHP;
        set => canUpHP = value;
    }

    public CharInfo CharInfo
    {
        get => _charInfo;
        set => _charInfo = value;
    }

    /// <summary>
    /// tang hay giam HP phu thuoc vao dau cua hp
    /// </summary>
    /// <param name="hp"></param>
    public void UpdateHP(int hp)
    {
        if(hp>0 && canUpHP==false) return;// trong truong hop khong the hoi mau
        _charInfo.hp += hp;
        if (_charInfo.hp < 0) _charInfo.hp = 0;
    }

    public void SetSpeed(int sp)
    {
        _charInfo.speed = sp;
    }

    public void SetDmg(int dmg)
    {
        _charInfo.dmg = dmg;
    }
}
