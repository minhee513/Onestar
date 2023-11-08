using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    SpriteRenderer spriteRdr;

    private void Start()
    {
        spriteRdr = GetComponent<SpriteRenderer>(); // 현재 게임 오브젝트가 가지고 있는 <> 타입의 컴포넌트 가져오기
    }

    public void ChangeSprite(Sprite s)
    {
        spriteRdr.sprite = s;
    }
}
