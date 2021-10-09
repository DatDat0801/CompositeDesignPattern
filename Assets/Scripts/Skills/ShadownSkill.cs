using UnityEngine;

namespace Skills
{
    public class ShadownSkill : BaseSkill
    {

        public override void Excute(BaseCharacter baseCharacter)
        {
            base.Excute(baseCharacter);
            DoSkill(idEffect, baseCharacter);
        }

        void DoSkill(int idEffect, BaseCharacter baseCharacter)
        {
            switch (idEffect)
            {
                case 1:
                    Effect1(baseCharacter);
                    break;
                case 2:
                    Effect2(baseCharacter);
                    break;
            }
        }

        /// <summary>
        /// effect qua cau bong toi: gay choang va khong con kha nang tan cong
        /// </summary>
        /// <param name="baseCharacter"></param>
        public void Effect1(BaseCharacter baseCharacter)
        {
            baseCharacter.SetSpeed(0);
            baseCharacter.SetDmg(0);
        }


        /// <summary>
        /// effect: hut hp cua doi thu
        /// </summary>
        /// <param name="baseCharacter"></param>
        public void Effect2(BaseCharacter baseCharacter)
        {
            baseCharacter.UpdateHP(-5);
            _user.UpdateHP(5);
        }

        public ShadownSkill(E_Elements element, E_Category category, BaseCharacter user) : base(element, category, user)
        {
        }
    }
}