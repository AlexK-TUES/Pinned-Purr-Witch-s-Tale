using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnClickScene : MonoBehaviour
{
    [SerializeField] private string m_name;
    public void ChangeScene()
    {
        SceneManager.LoadScene(m_name);
        SceneManager.SetActiveScene(gameObject.scene);
        SceneManager.UnloadSceneAsync(gameObject.scene);
    }
}
