using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] 
    private GameObject mainMenu;

    [SerializeField] 
    private GameObject splashScreen;

    [SerializeField] 
    private Text progressBarText;

    public void StartGame()
    {
        StartCoroutine(LoadAsync());
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    private IEnumerator LoadAsync()
    {
        AsyncOperation AsyncLoad = SceneManager.LoadSceneAsync(1);//����������� �������� �����

        AsyncLoad.allowSceneActivation = false;//��������� �������� �����, ����...

        while (!AsyncLoad.isDone)//���� ����� �� ���������
        {
            //LoadingBar.value = AsyncLoad.progress;//�������� � ������� - ��������, ���� �� ������� ��������� ��������� �����
            mainMenu.SetActive(false);
            splashScreen.SetActive(true);
            progressBarText.text = Mathf.RoundToInt(AsyncLoad.progress * 100) + "%";//�������� � ����� - ����� ��������)

            if (AsyncLoad.progress >= .9f && !AsyncLoad.allowSceneActivation)//���� �������� �������� �����/������ 0,9 � ����� �� ������������, �� ...
            {
                if (Input.anyKeyDown)//���� ������ ����� ������, ��...
                {
                    AsyncLoad.allowSceneActivation = true;//��������� �����
                }
            }

            yield return null;//���������� ������
        }
    }
}