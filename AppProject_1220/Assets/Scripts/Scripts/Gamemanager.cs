using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Gamemanager : MonoBehaviour
{
    [Header("INFO物件拉條")]
    public Scrollbar InfoScrollbar;
    public Image Info;
    [Header("要改變的圖片")]
    public Sprite[] InfoChangeImage;
    // Start is called before the first frame update

    void Start()
    {
        InfoScrollbar = GameObject.Find("跑馬燈拉條").GetComponent<Scrollbar>();
        Info = GameObject.Find("可改變宣傳圖片").GetComponent<Image>();
        Screen.SetResolution(1080, 1920, false);
        InvokeRepeating("fixedInfo", 0f, 15f);

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

        for (int i = 0; i < InfoChangeImage.Length; i++)
        {

            Info.sprite = InfoChangeImage[i];
            yield return new WaitForSeconds(3f);
        }


    }
    public void fixedInfo()
    {
        StartCoroutine(ChangeInfo());
    }



}
