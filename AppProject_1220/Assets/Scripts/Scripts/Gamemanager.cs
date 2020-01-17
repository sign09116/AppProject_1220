using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Gamemanager : MonoBehaviour
{
    [Header("INFO物件拉條")]
    public Scrollbar InfoScrollbar;
    public Image Info;
    public Color[] Colors;
    // Start is called before the first frame update

    void Start()
    {

        Screen.SetResolution(1080, 1920, false);
        InvokeRepeating("fixedInfo", 5f, 5f);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    public IEnumerator ChangeInfo()
    {
        InfoScrollbar.value = 0;
        for (int i = 0; i < 20; i++)
        {

            yield return new WaitForSeconds(0.05f);
            InfoScrollbar.value += 0.05f;
        }
        Info.color = Colors[Random.Range(0, 3)];

    }
    public void fixedInfo()
    {
        StartCoroutine(ChangeInfo());
    }



}
