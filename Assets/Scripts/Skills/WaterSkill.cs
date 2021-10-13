// using UnityEngine;

// public class WaterSkill : BaseSkill
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
//     /// effect hoi phuc hp
//     /// </summary>
//     /// <param name="baseCharacter"></param>
//     public void Effect1(BaseCharacter baseCharacter)
//     {
//         _user.UpdateHP(10);
//     }


//     /// <summary>
//     /// effect: tia nuoc gay sat thuong x2
//     /// </summary>
//     /// <param name="baseCharacter"></param>
//     public void Effect2(BaseCharacter baseCharacter)
//     {
//         baseCharacter.UpdateHP(-5*2);
//     }

//     public WaterSkill(E_Elements element, E_Category category, BaseCharacter user) : base(element, category, user)
//     {
//     }
// }