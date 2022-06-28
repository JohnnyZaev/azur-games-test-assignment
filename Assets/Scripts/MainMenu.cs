using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void LoadLevel(int level)
	{
		PlayerPrefs.SetInt("level", level);
		SceneManager.LoadScene(0);
	}
}
