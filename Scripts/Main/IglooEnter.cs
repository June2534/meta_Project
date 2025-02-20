using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IglooEnter : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 플레이어가 닿으면
        {
            Debug.Log("미니게임으로 이동!"); // 콘솔 출력 확인
            SceneManager.LoadScene("MiniGameScene"); //미니게임 씬으로 이
        }
    }
}
