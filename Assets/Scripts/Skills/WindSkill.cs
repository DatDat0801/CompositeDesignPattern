// using UnityEngine;
// public class WindSkill : BaseSkill
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
//     /// effect day doi thu lui lai phia sau
//     /// </summary>
//     /// <param name="baseCharacter"></param>
//     public void Effect1(BaseCharacter baseCharacter)
//     {
//         Rigidbody2D rb = baseCharacter.GetComponent<Rigidbody2D>();
//         rb.velocity= Vector2.right*3f;
//     }


//     /// <summary>
//     /// effect: cat khong khi => gay sat thuong x2 va enemy khong the hoi mau
//     /// </summary>
//     /// <param name="baseCharacter"></param>
//     public void Effect2(BaseCharacter baseCharacter)
//     {
//         baseCharacter.UpdateHP(-5*2);
//         baseCharacter.CanUpHp = false;
//     }

//     public WindSkill(E_Elements element, E_Category category, BaseCharacter user) : base(element, category, user)
//     {
//     }
// }