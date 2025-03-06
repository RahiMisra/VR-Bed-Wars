using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public TextMeshProUGUI leveltext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        leveltext.text = level.ToString();
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Level " + level.ToString());
    }
}
