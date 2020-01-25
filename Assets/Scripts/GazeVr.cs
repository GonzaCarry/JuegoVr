using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GazeVr : MonoBehaviour
{
    public Image imgGaze;

    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    //lvl 1

    public GameObject rtd;
    public GameObject rdd;
    public GameObject ltd;
    public GameObject ldd;

    //lvl 2

    public GameObject td;
    public GameObject dd;
    public GameObject lbd;

    public GameObject lbb;
    public GameObject lvl2Text;

    // map elements

    public GameObject rg;
    public GameObject lg;

    public GameObject tp;

    public GameObject tpMsg;
    public GameObject tBMsg;
    public GameObject lBMsg;
    public GameObject DianaMsg;

    public GameObject WinText;

    public int contador;

    Vector3 rgPos;
    Vector3 lgPos;

    private int distanceOfRay = 50;
    private RaycastHit _hit;

    // Start is called before the first frame update
    void Start()
    {
        rgPos = rg.transform.localPosition;
        lgPos = lg.transform.localPosition;

        tp.SetActive(true);

        tpMsg.SetActive(true);
        tBMsg.SetActive(false);
        lBMsg.SetActive(false);
        DianaMsg.SetActive(false);

        rtd.SetActive(true);
        rdd.SetActive(true);
        ltd.SetActive(true);
        ldd.SetActive(true);

        td.SetActive(false);
        dd.SetActive(false);
        lbd.SetActive(false);

        lvl2Text.SetActive(false);

        lbb.SetActive(false);

        WinText.SetActive(false);

        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if(Physics.Raycast(ray, out _hit, distanceOfRay))
        {
            if(imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Teleport"))
            {
                _hit.transform.gameObject.GetComponent<Teleport>().TeleportPlayer();
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                tp.SetActive(false);
                tpMsg.SetActive(false);
                tBMsg.SetActive(true);
                DianaMsg.SetActive(true);
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Bottle"))
            {
                _hit.transform.gameObject.GetComponent<BottleGrabTime>().BottleGrabT();
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                tBMsg.SetActive(false);
                lBMsg.SetActive(true);
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("BottlePosition"))
            {
                _hit.transform.gameObject.GetComponent<BottlePut>().BottlePutOn();
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                tBMsg.SetActive(true);
                lBMsg.SetActive(false);
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("rtd"))
            {
                //_hit.transform.gameObject.GetComponent<GlovesHits>().RHitUp();
                StartCoroutine(RHitUp());
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                contador++;
                Debug.Log(contador);
                //rg.transform.localPosition = rgPos;
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("rdd"))
            {
                //_hit.transform.gameObject.GetComponent<GlovesHits>().RHitUp();
                StartCoroutine(RHitDown());
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                contador++;
                Debug.Log(contador);
                //rg.transform.localPosition = rgPos;
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("ltd"))
            {
                //_hit.transform.gameObject.GetComponent<GlovesHits>().RHitUp();
                StartCoroutine(LHitUp());
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                contador++;
                Debug.Log(contador);
                //rg.transform.localPosition = rgPos;
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("ldd"))
            {
                //_hit.transform.gameObject.GetComponent<GlovesHits>().RHitUp();
                StartCoroutine(LHitDown());
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                contador++;
                Debug.Log(contador);
                //rg.transform.localPosition = rgPos;
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("exit"))
            {
                SceneManager.LoadScene("Menu");
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("StartButton"))
            {
                //_hit.transform.gameObject.GetComponent<GlovesHits>().RHitUp();
                StartCoroutine(HitStart());
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                //rg.transform.localPosition = rgPos;
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("ExitButton"))
            {
                //_hit.transform.gameObject.GetComponent<GlovesHits>().RHitUp();
                StartCoroutine(HitExit());
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                //rg.transform.localPosition = rgPos;
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("td"))
            {
                //_hit.transform.gameObject.GetComponent<GlovesHits>().RHitUp();
                StartCoroutine(HitTop());
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                contador++;
                Debug.Log(contador);
                //rg.transform.localPosition = rgPos;
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("dd"))
            {
                //_hit.transform.gameObject.GetComponent<GlovesHits>().RHitUp();
                StartCoroutine(HitDown());
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                contador++;
                Debug.Log(contador);
                //rg.transform.localPosition = rgPos;
            }
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("lbd"))
            {
                //_hit.transform.gameObject.GetComponent<GlovesHits>().RHitUp();
                StartCoroutine(HitLittleBag());
                gvrStatus = false;
                gvrTimer = 0;
                imgGaze.fillAmount = 0;
                contador++;
                Debug.Log(contador);
                //rg.transform.localPosition = rgPos;
            }
        }

        if (contador == 1)
        {
            DianaMsg.SetActive(false);
        }

        if (contador == 4)
        {
            lvl2Text.SetActive(true);

            td.SetActive(true);
            dd.SetActive(true);
            lbd.SetActive(true);

            lbb.SetActive(true);
        }

        if (contador == 5)
        {
            lvl2Text.SetActive(false);

        }

        if (contador == 7)
        {
            StartCoroutine(YouWin());
        }
    }

    IEnumerator YouWin()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        WinText.SetActive(true);

        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Menu");

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator HitTop()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        rg.transform.localPosition = new Vector3(0.06f, 1.44f, 2.97f);


        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(0.3f);

        rg.transform.localPosition = rgPos;
        td.SetActive(false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator HitDown()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        lg.transform.localPosition = new Vector3(-0.15f, 1.39f, 3.3f);


        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(0.3f);

        lg.transform.localPosition = lgPos;
        dd.SetActive(false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator HitLittleBag()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        rg.transform.localPosition = new Vector3(0.31f, 1.43f, 2.54f);
        lg.transform.localPosition = new Vector3(-0.56f, 1.48f, 2.59f);

        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(0.3f);

        rg.transform.localPosition = rgPos;
        lg.transform.localPosition = lgPos;
        lbd.SetActive(false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator HitStart()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        rg.transform.localPosition = new Vector3(-0.04f, 1.43f, 6.28f);


        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(0.3f);

        rg.transform.localPosition = rgPos;
        SceneManager.LoadScene("lvl1");

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator HitExit()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        lg.transform.localPosition = new Vector3(-0.14f, 1.52f, 5.65f);


        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(0.3f);

        lg.transform.localPosition = lgPos;
        //SceneManager.LoadScene("GameScene");

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
    IEnumerator RHitUp()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        rg.transform.localPosition = new Vector3(-0.15f, 1.32f, 3.10f);


        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(0.3f);

        rg.transform.localPosition = rgPos;
        rtd.SetActive(false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator RHitDown()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        rg.transform.localPosition = new Vector3(-0.14f, 1.45f, 3.21f);


        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(0.3f);

        rg.transform.localPosition = rgPos;
        rdd.SetActive(false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator LHitUp()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        lg.transform.localPosition = new Vector3(-0.07f, 1.34f, 3.06f);


        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(0.3f);

        lg.transform.localPosition = lgPos;
        ltd.SetActive(false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    IEnumerator LHitDown()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        lg.transform.localPosition = new Vector3(-0.07f, 1.34f, 3.06f);


        //yield on a new YieldInstruction that waits for 1 seconds.
        yield return new WaitForSeconds(0.3f);

        lg.transform.localPosition = lgPos;
        ldd.SetActive(false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }
}
