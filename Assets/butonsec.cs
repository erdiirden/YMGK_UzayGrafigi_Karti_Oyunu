using UnityEngine;
using UnityEngine.UI;

public class butonsec : MonoBehaviour
{
    private Button button;
    private Color orjinalrenk = Color.white;
    private Color kirmizirenk = Color.red;
    private bool isRed = false;
    public Button btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10;
    public GameObject yildiz;
    private int sayi;

    void Start()
    {
        button = GetComponent<Button>();
        button.image.color = orjinalrenk;
    }
    void Update()
    {
        if (btn1.image.color == kirmizirenk && btn2.image.color == kirmizirenk && btn3.image.color == kirmizirenk && btn4.image.color == kirmizirenk && btn5.image.color == kirmizirenk && btn6.image.color == kirmizirenk && btn7.image.color == kirmizirenk && btn8.image.color == kirmizirenk && btn9.image.color == kirmizirenk && btn10.image.color == kirmizirenk)
        {
            Debug.Log("Yýldýz");
            yildiz.SetActive(true);
        }
        else
        {
            yildiz.SetActive(false);
        }
    }


    public void renkdegistir()
    {
        if (isRed)
        {
            button.image.color = orjinalrenk;
        }
        else
        {
            button.image.color = kirmizirenk;
        }

        isRed = !isRed;
    }
}