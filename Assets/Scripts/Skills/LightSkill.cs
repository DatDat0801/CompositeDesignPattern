// using UnityEngine;

// public class LightSkill : BaseSkill
// {
//     public override void Excute(BaseCharacter baseCharacter)
//     {
//         base.Excute(baseCharacter);
//         DoSkill(idEffect,baseCharacter);
//     }

//     void DoSkill(int idEffect,BaseCharacter baseCharacter)
//     {
//         switch (idEffect)
//         {
//             case 1:
//                 Effect1(baseCharacter);
//                 break;
//             case 2:
//                 Effect2(baseCharacter);
//                 break;
//         }
//     }
    
//     /// <summary>
//     /// effect ban tia sang, gay choang
//     /// </summary>
//     /// <param name="baseCharacter"></param>
//     public void Effect1(BaseCharacter baseCharacter)
//     {
//         baseCharacter.UpdateHP(-3);
//         baseCharacter.SetSpeed(0);// gay choang => khong di chuyen duoc
//     }


//     /// <summary>
//     /// effect Light Wall => tao nen buc tuong phong thu
//     /// </summary>
//     /// <param name="baseCharacter"></param>
//     public void Effect2(BaseCharacter baseCharacter)
//     {
//         baseCharacter.SetSpeed(0);// coi nhu khi cham vao enemy se khogn di chuyen duoc
//     }

//     public LightSkill(E_Elements element, E_Category category, BaseCharacter user) : base(element, category, user)
//     {
//     }
// }