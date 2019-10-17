using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayBtnScript : MonoBehaviour
{
    public Button playBtn;
    public string SceneName = "A51 RAID";
    // Start is called before the first frame update
    void Start()
    {
        playBtn.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(SceneName);
    }
}
