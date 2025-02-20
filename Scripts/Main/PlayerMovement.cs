using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb; // 캐릭터의 물리 엔진 (중력, 점프 등)
    private Animator anim; // 애니메이션 관리
    private SpriteRenderer spriteRenderer; // 좌우 반전(Flipx) 처리용

    public float moveSpeed = 5f; // 이동 속도
 
    void Start()
    {        
       //필요한 컴포넌트 가져오기
       rb = GetComponent<Rigidbody2D>(); // Rigidbody2D 가져오기
       anim = GetComponent<Animator>(); //Animator 가져오기
       spriteRenderer = GetComponent<SpriteRenderer>(); // SpriteRenderer 가져오기
    }

    void Update()
    {
        // 방향키 이동 처리
        float moveX = 0;
        float moveY = 0;
        
        
        if (Input.GetKey(KeyCode.LeftArrow)) moveX = -1;
        if (Input.GetKey(KeyCode.RightArrow)) moveX = 1;
        if (Input.GetKey(KeyCode.UpArrow)) moveY = 1;
        if (Input.GetKey(KeyCode.DownArrow)) moveY = -1;
        
        // 이동 속도 적용
        Vector2 moveInput = new Vector2(moveX, moveY).normalized;
        rb.velocity = moveInput * moveSpeed;
        
        // 걷기 애니메이션 설정
        anim.SetBool("isWalking", moveInput.magnitude > 0);
        
        // 좌우 방향 전환 ( 왼쪽으로 갈 때 FlipX 설정)
        if (moveX < 0)
            spriteRenderer.flipX = true; // 왼쪽 이동 시 반전
        else if (moveX > 0)
            spriteRenderer.flipX = false; // 오른쪽 이동 시 원래 방향
    }
}
