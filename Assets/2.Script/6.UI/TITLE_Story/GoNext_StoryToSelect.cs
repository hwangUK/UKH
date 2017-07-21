using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNext_StoryToSelect : MonoBehaviour {

    public void Select_and_Go()
    {
        if (UserInformation.Instance.ISFIRST == 0)
            SceneManager.LoadScene(2);
        else if (UserInformation.Instance.ISFIRST == 1)
            SceneManager.LoadScene(3);
    }
}
