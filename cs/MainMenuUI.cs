using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    // استدعاء عند الضغط على زر "ابدأ اللعبة"
    public void StartGame()
    {
        SceneManager.LoadScene("FIRST"); // اسم مشهد اللعبة الرئيسي
    }

    // استدعاء عند الضغط على زر "خروج"
  
     public void Main()
    {
        SceneManager.LoadScene("Back"); // اسم مشهد اللعبة الرئيسي
    }
      public void BACK()
    {
        SceneManager.LoadScene("MAINM"); // اسم مشهد اللعبة الرئيسي
    }
      public void Siting()
    {
        SceneManager.LoadScene("Sitting"); // اسم مشهد اللعبة الرئيسي
    }
}
