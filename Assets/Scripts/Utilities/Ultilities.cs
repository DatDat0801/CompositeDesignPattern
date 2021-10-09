using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ultilities : Singleton<Ultilities>
{
    public void RunCoroutine(IEnumerator IE)
    {
        StartCoroutine(IE);
    }
}
