using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 따라갈 플레이어를 저장할 변수
    public Transform player;

    // 카메라가 부드럽게 따라가는 속도
    public float smoothSpeed = 0.125f;

    // 카메라의 위치 보정 (조금 위쪽에 위치할 수도 있)
    public Vector3 offset;

    void LateUpdate()
    {
        // 목표 위치 계산 (플레이어 위치 + 오프)
        Vector3 targetPosition = player.position + offset;

        // Lerp를 사용하여 부드럽게 이동 (현재 위치에서 목표 위치로 이동)
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
    }
}
