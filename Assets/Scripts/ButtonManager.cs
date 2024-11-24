using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject menuBar;
    public GameObject challenge;
    public GameObject announcement;
    public GameObject mailBox;
    public GameObject setting;
    public GameObject pedigree;
    public GameObject miningStatus;

    private bool isMenuBarActive = false;
    private bool isChallengeActive = false;
    private bool isAnnouncementActive = false;
    private bool isMailBoxActive = false;
    private bool isSettingActive = false;
    private bool isPedigreeActive = false;
    private bool isMiningStatusActive = false;

    public GameObject question;

    private bool isQuestionActive = false;

    public GameObject stoneTower;

    private bool isStoneTowerActive = false;

    private enum SceneType
    {
        Shop,
        Build,
        Upgrade,
        Skin
    }

    private SceneType currentScene;

    private void Start()
    {
        currentScene = GetCurrentSceneType();

        if (menuBar != null)                // �޴�
        {
            menuBar.SetActive(false);
        }

        if (challenge != null)              // ��������
        {
            challenge.SetActive(false);
        }

        if (announcement != null)           // ��������
        {
            announcement.SetActive(false);
        }

        if (mailBox != null)                // ������
        {
            mailBox.SetActive(false);
        }

        if (setting != null)                // ����
        {
            setting.SetActive(false);
        }

        if (pedigree != null)               // ����
        {
            pedigree.SetActive(false);
        }

        if (miningStatus != null)           // ä����Ȳ
        {
            miningStatus.SetActive(false);
        }

        if (question != null)
        {
            question.SetActive(false);
        }

        if (stoneTower != null)
        {
            stoneTower.SetActive(false);
        }
    }

    public void Shop()
    {
        ChangeScene(SceneType.Shop);
    }

    public void Build()
    {
        ChangeScene(SceneType.Build);
    }

    public void Upgrade()
    {
        ChangeScene(SceneType.Upgrade);
    }

    public void Skin()
    {
        ChangeScene(SceneType.Skin);
    }

    private void ChangeScene(SceneType targetScene)
    {
        if (currentScene != targetScene)
        {
            string sceneName = targetScene.ToString() + "Scene";
            SceneManager.LoadScene(sceneName);
            currentScene = targetScene;
        }
        else     // �� �ߺ� ��ȯ ����
        {
            Debug.Log("�̹� " + targetScene.ToString() + " ���� �ֽ��ϴ�.");
        }
    }

    public void MenuBar()
    {
        if (menuBar != null)
        {
            if (isMenuBarActive)
            {
                menuBar.SetActive(false);
                isMenuBarActive = false;
            }
            else
            {
                menuBar.SetActive(true);
                isMenuBarActive = true;
            }
        }
    }

    public void MenuBar_Close()
    {
        if (menuBar != null) menuBar.SetActive(false);
        isMenuBarActive = false;
    }


    public void Challenge()
    {
        if (challenge != null)
        {
            isChallengeActive = !isChallengeActive;
            challenge.SetActive(isChallengeActive);
        }
    }

    public void Challenge_Close()
    {
        if (challenge != null) challenge.SetActive(false);
        isChallengeActive = false;
    }

    public void Announcement()
    {
        if (announcement != null)
        {
            isAnnouncementActive = !isAnnouncementActive;
            announcement.SetActive(isAnnouncementActive);
        }
    }

    public void Announcement_Close()
    {
        if (announcement != null) announcement.SetActive(false);
        isAnnouncementActive = false;
    }

    public void MailBox()
    {
        if (mailBox != null)
        {
            isMailBoxActive = !isMailBoxActive;
            mailBox.SetActive(isMailBoxActive);
        }
    }

    public void MailBox_Close()
    {
        if (mailBox != null) mailBox.SetActive(false);
        isMailBoxActive = false;
    }

    public void Setting()
    {
        if (setting != null)
        {
            isSettingActive = !isSettingActive;
            setting.SetActive(isSettingActive);
        }
    }

    public void Setting_Close()
    {
        if (setting != null) setting.SetActive(false);
        isSettingActive = false;
    }

    public void Pedigree()
    {
        if (pedigree != null)
        {
            isPedigreeActive = !isPedigreeActive;
            pedigree.SetActive(isPedigreeActive);
        }
    }

    public void Pedigree_Close()
    {
        if (pedigree != null) pedigree.SetActive(false);
        isPedigreeActive = false;
    }

    public void Mining_Status()
    {
        if (miningStatus != null)
        {
            isMiningStatusActive = !isMiningStatusActive;
            miningStatus.SetActive(isMiningStatusActive);
        }
    }

    public void Mining_Status_Close()
    {
        if (miningStatus != null) miningStatus.SetActive(false);
        isMiningStatusActive = false;
    }

    public void Question()
    {
        if (question != null)
        {
            isQuestionActive = !isQuestionActive;
            question.SetActive(isQuestionActive);
        }
    }

    public void Question_Close()
    {
        if (question != null) question.SetActive(false);
        isQuestionActive = false;
    }

    public void Stone_Tower()
    {
        if (stoneTower != null)
        {
            isStoneTowerActive = !isStoneTowerActive;
            stoneTower.SetActive(isStoneTowerActive);
        }
    }

    public void Stone_Tower_Close()
    {
        if (stoneTower != null) stoneTower.SetActive(false);
        isStoneTowerActive = false;
    }

    private SceneType GetCurrentSceneType()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        return (SceneType)System.Enum.Parse(typeof(SceneType), currentSceneName.Replace("Scene", ""));
    }
}
