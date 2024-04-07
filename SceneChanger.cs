using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string SceneName;

    void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(SceneName);
    }
}
