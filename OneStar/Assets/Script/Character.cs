using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    SpriteRenderer spriteRdr;

    private void Start()
    {
        spriteRdr = GetComponent<SpriteRenderer>(); // ���� ���� ������Ʈ�� ������ �ִ� <> Ÿ���� ������Ʈ ��������
    }

    public void ChangeSprite(Sprite s)
    {
        spriteRdr.sprite = s;
    }
}
