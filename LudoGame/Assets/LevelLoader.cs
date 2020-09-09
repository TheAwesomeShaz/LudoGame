using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitandLoadScene());
    }

    IEnumerator WaitandLoadScene()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }
}
