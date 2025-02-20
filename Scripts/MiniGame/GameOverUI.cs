using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject gameOverPanel; // UI 패널
    public Button restartButton; // 다시 하기 버튼
    public Button mainMenuButton; // 돌아가기 버튼

    void Start()
    {
        gameOverPanel.SetActive(false); // 시작할 때 UI 숨김

        restartButton.onClick.AddListener(RestartGame);
        mainMenuButton.onClick.AddListener(ReturnToMainMenu);
    }

    public void ShowGameOverUI()
    {
        gameOverPanel.SetActive(true); // UI 보이게 하기
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 현재 씬 다시 로드
    }

    void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainScene"); // 메인 씬으로 이동
    }
}
