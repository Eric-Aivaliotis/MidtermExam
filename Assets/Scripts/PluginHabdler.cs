using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class PluginHabdler : MonoBehaviour
{
    const string DLL_NAME = "EnginesDLLTut";


    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    [DllImport(DLL_NAME)]
    private static extern void SaveCheckpointTime(float RTBC);

    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckpointTime(int RTBC);

    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoint();

    float lastTime = 0.0f;

    bool cpTimer1 = true;                   // These are the timers for each of the checkpoints 
    bool cpTimer2 = true;                   // 
    bool cpTimer3 = true;                   //
    bool cpTimer4 = true;                   //
    bool cpTimer5 = true;                   //

    public Text displayTime;

    public void CaptureTime(float CPTime)
    {
        SaveCheckpointTime(CPTime);
    }


    public float Load_times(int i)
    {
        if (i >= GetNumCheckpoint())
        {
            return -1.0f;
        }
        else
        {
            return GetCheckpointTime(i);
        }
    }


    public float LoadOverallTime()
    {
        return GetTotalTime();
    }

    public void ResetTimes()
    {
        ResetLogger();
    }





    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;
        CaptureTime(lastTime);
        LoadOverallTime();

    }

    // Update is called once per frame
    void Update()
    {

        if ((GameObject.FindGameObjectWithTag("Player").transform.localPosition.x == GameObject.FindGameObjectWithTag("cp").transform.localPosition.x) && cpTimer1 == true)
        {
            
            float cur_time = Time.time;
            float cpTime = cur_time - lastTime;
            lastTime = cur_time;

            

            CaptureTime(cpTime);

            displayTime.text = LoadOverallTime().ToString();

            Debug.Log(LoadOverallTime());

            cpTimer1 = false;
        }

        if ((GameObject.FindGameObjectWithTag("Player").transform.localPosition.z == GameObject.FindGameObjectWithTag("cp2").transform.localPosition.z) && cpTimer2 == true)
        {
            cpTimer2 = false;
            float cur_time = Time.time;
            float cpTime = cur_time - lastTime;
            lastTime = cur_time;

            

            CaptureTime(cpTime);
        }

        if ((GameObject.FindGameObjectWithTag("Player").transform.localPosition.x == GameObject.FindGameObjectWithTag("cp3").transform.localPosition.x) && cpTimer3 == true)
        {
            cpTimer3 = false;
            float cur_time = Time.time;
            float cpTime = cur_time - lastTime;
            lastTime = cur_time;

            

            CaptureTime(cpTime);
        }

        if ((GameObject.FindGameObjectWithTag("Player").transform.localPosition.x == GameObject.FindGameObjectWithTag("cp4").transform.localPosition.x) && cpTimer4 == true)
        {
            cpTimer4 = false;
            float cur_time = Time.time;
            float cpTime = cur_time - lastTime;
            lastTime = cur_time;

            

            CaptureTime(cpTime);
        }

        if ((GameObject.FindGameObjectWithTag("Player").transform.localPosition.z == GameObject.FindGameObjectWithTag("cp5").transform.localPosition.z) && cpTimer5 == true)
        {   
            cpTimer5 = false;
            float cur_time = Time.time;
            float cpTime = cur_time - lastTime;
            lastTime = cur_time;

           

            CaptureTime(cpTime);
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    float currentTime = Time.time;
        //    float checkpointTime = currentTime - lastTime;
        //    lastTime = currentTime;

        //    SaveTimwTest(checkpointTime);

        //    for (int i = 0; i < 10; i++)
        //    {
        //        if (Input.GetKeyDown(KeyCode.Alpha0 + i))
        //        {
        //            Debug.Log(LoadTimeTest(i));
        //        }

        //        if (Input.GetKeyDown(KeyCode.T))
        //        {
        //            Debug.Log(LoadTotalTimeTest());
        //        }
        //    }
        //}
    }
}
