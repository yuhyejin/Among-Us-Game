using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatigCrew : MonoBehaviour
{
    public EPlayerColor playerColor;

    private SpriteRenderer spriteRenderer;  //떠다니는 크루원의 색상
    private Vector3 direction;  //크루원이 날아다니는 방향
    private float floatingSpeed;    //크루원이 날아다니는 속도
    private float rotateSpeed;   // 날아다니면서 회전하는 속도

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SetFloatingCrew(Sprite sprite, EPlayerColor playerColor, Vector3 direction, float floatingSpeed, float rotateSpeed, float size)
    {
        this.playerColor = playerColor;
        this.direction = direction;
        this.floatingSpeed = floatingSpeed;
        this.rotateSpeed = rotateSpeed;

        spriteRenderer.sprite = sprite;
        spriteRenderer.material.SetColor("_PlayerColor", PlayerColor.GetColor(playerColor));

        transform.localScale = new Vector3(size, size, size);
        spriteRenderer.sortingOrder = (int)Mathf.Lerp(1, 32767, size);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * floatingSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, 0f, rotateSpeed));
    }
}
