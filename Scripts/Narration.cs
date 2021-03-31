 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
using DG.Tweening;

// Ctrl + K + C = 전체 주석 <-> 전체 해제 = Ctrl + K + U, Ctrl + K + F = 줄정렬
public class Narration : MonoBehaviour
{
    public GameObject AhriFace;
    public GameObject ArchFace;
    public GameObject SurpriseAhri;
    public GameObject NarrationBox;

    public Text AhriText;
    public Text ArchText;
    public Text SurpriseAhriText;
    public Text NarrationText;

    private AudioSource audioSource; // 카세트
    public AudioClip blop; // 테이프
    public AudioClip keyboard;
    public AudioClip alarm;

    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        
        if (SceneManager.GetActiveScene().name.Equals("4_0EarthQuake"))
        {
            StartCoroutine(EarthQuake4_0Dialogue()); 
        }

        else if(SceneManager.GetActiveScene().name.Equals("5_0EarthQuake")){
            StartCoroutine(EarthQuake5_0Dialogue());
        }

        else if (SceneManager.GetActiveScene().name.Equals("6_0EarthQuake"))
        {
            StartCoroutine(EarthQuake6_0Dialogue());
        }

        else
        {
            StartCoroutine(StartDialogue());
        }
    }

    void Update()
    {
        
    }

    void SizeUp(GameObject Image) // 채팅창 웅 하면서 뜨게 하는 함수
    {
        AhriText.text = "";
        ArchText.text = "";
        Image.SetActive(true);
        audioSource.PlayOneShot(blop); // 짧은 소리, 노래는 Play()로;
        Image.transform.DOScale(1.0f, 0.1f);
    }

    IEnumerator SizeDown(GameObject Image) // 채팅창 사라지게 하는 것(작아지고 나서 사라져야 하는데 기다려야 해서 코루틴을 씀)
    {
        Image.transform.DOScale(0.0f, 0.1f);
        audioSource.PlayOneShot(blop); // 짧은 소리, 노래는 Play()로;
        yield return new WaitForSeconds(0.1f);
        Image.SetActive(false);
    }

    IEnumerator StartDialogue()
    {
        NarrationText.text = "";
        NarrationBox.SetActive(true);
        NarrationText.DOText("아리와 아치는 지진 체험을 위해 학교에 남았다.", 3.0f);
        yield return new WaitForSeconds(4.0f);
        NarrationBox.SetActive(false);

        SizeUp(AhriFace); // 아리 채팅 커짐, 뽁 소리
        AhriText.DOText("아치야, 칠판에 뭔가 있어!!!", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(AhriFace)); // 아리 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        SizeUp(ArchFace); // 아치 채팅 커짐, 뽁 소리
        ArchText.DOText("엇! 어디있지? 빨리 체험해보고 싶다!!!", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(ArchFace)); // 아치 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        NarrationText.text = "";
        NarrationBox.SetActive(true);
        NarrationText.DOText("칠판에 체험하고 싶은 강도를 2초간 봐라봐 주세요.", 3.0f);
        yield return new WaitForSeconds(4.0f);
        NarrationBox.SetActive(false);
    }

    IEnumerator EarthQuake4_0Dialogue()
    {
        NarrationText.text = "";
        NarrationBox.SetActive(true);
        NarrationText.DOText("4.0 지진체험을 시작합니다... 드드드.. 드드드...", 3.0f);
        yield return new WaitForSeconds(4.0f);
        NarrationBox.SetActive(false);

        SizeUp(SurpriseAhri); // 아리 채팅 커짐, 뽁 소리
        SurpriseAhriText.DOText("아악! 뭐야, 진짜 교실이 흔들리고 있는거 같아!", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(SurpriseAhri)); // 아리 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        ArchText.text = "";
        SizeUp(ArchFace); // 아치 채팅 커짐, 뽁 소리
        ArchText.DOText("TV가 떨어지고, 시계도 떨어져서 깨졌어!", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(ArchFace)); // 아치 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        SurpriseAhriText.text = "";
        SizeUp(SurpriseAhri); // 아리 채팅 커짐, 뽁 소리
        SurpriseAhriText.DOText("오..오오! 4.0의 지진은 이 정도구나", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(SurpriseAhri)); // 아리 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        NarrationText.text = "";
        NarrationBox.SetActive(true);
        NarrationText.DOText("10초 후 자동으로 체험을 종료합니다.", 3.0f);
        yield return new WaitForSeconds(10.0f);
        NarrationBox.SetActive(false);

        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("Re_Celect_DongJin_EarthQuake");
    }

    IEnumerator EarthQuake5_0Dialogue()
    {
        NarrationText.text = "";
        NarrationBox.SetActive(true);
        NarrationText.DOText("5.0 지진체험을 시작합니다... 드드드드.... 드드드...", 3.0f);
        yield return new WaitForSeconds(4.0f);
        NarrationBox.SetActive(false);

        SizeUp(SurpriseAhri); // 아리 채팅 커짐, 뽁 소리
        SurpriseAhriText.DOText("아악! 이게 5.0강도의 지진인가?", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(SurpriseAhri)); // 아리 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        SizeUp(ArchFace); // 아치 채팅 커짐, 뽁 소리
        ArchText.DOText("우아아,,, 서있기가 힘들정도야!!", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(ArchFace)); // 아치 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        SurpriseAhriText.text = ""; 
        SizeUp(SurpriseAhri); // 아리 채팅 커짐, 뽁 소리
        SurpriseAhriText.DOText("저길 봐바!! 창문도 깨지고 있어!", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(SurpriseAhri)); // 아리 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        SizeUp(ArchFace); // 아치 채팅 커짐, 뽁 소리
        ArchText.DOText("창문의 파편을 조심해!, 5.0지진은 정말 위험하구나?", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(ArchFace)); // 아치 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        NarrationText.text = "";
        NarrationBox.SetActive(true);
        NarrationText.DOText("10초 후 자동으로 체험을 종료합니다.", 3.0f);
        yield return new WaitForSeconds(10.0f);
        NarrationBox.SetActive(false);

        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("Re_Celect_DongJin_EarthQuake");
    }

    IEnumerator EarthQuake6_0Dialogue()
    {
        NarrationText.text = "";
        NarrationBox.SetActive(true);
        NarrationText.DOText("6.0 지진체험을 시작합니다... 쿠워아아아아앙..", 3.0f);
        yield return new WaitForSeconds(4.0f);
        NarrationBox.SetActive(false);

        SizeUp(SurpriseAhri); // 아리 채팅 커짐, 뽁 소리
        SurpriseAhriText.DOText("6.0지진은 칠판 쪽 벽에 금이가고 있어!!", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(SurpriseAhri)); // 아리 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        SizeUp(ArchFace); // 아치 채팅 커짐, 뽁 소리
        ArchText.DOText("아리야, 주위를 둘러보면 금 간 곳이 여러곳이야 ㅠㅠ", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(ArchFace)); // 아치 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        SurpriseAhriText.text = "";
        SizeUp(SurpriseAhri); // 아리 채팅 커짐, 뽁 소리
        SurpriseAhriText.DOText("창문은 5.0지진 때 보다 더 많이 깨지고 있어!", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(SurpriseAhri)); // 아리 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        NarrationText.text = "";
        NarrationBox.SetActive(true);
        NarrationText.DOText("우지직... 쩌적.. 쩍.. 쩍", 3.0f);
        yield return new WaitForSeconds(4.0f);
        NarrationBox.SetActive(false);

        // 경보음
        yield return new WaitForSeconds(6.0f);
        audioSource.clip = alarm;
        audioSource.Play();

        yield return new WaitForSeconds(9.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f);


        ArchText.text = "";
        SizeUp(ArchFace); // 아치 채팅 커짐, 뽁 소리
        ArchText.DOText("엇... 밖에 땅에 금이가고, 나무가 휘었어!", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(ArchFace)); // 아치 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        SurpriseAhriText.text = "";
        SizeUp(SurpriseAhri); // 아리 채팅 커짐, 뽁 소리
        SurpriseAhriText.DOText("차도 땅에 박혀있는 걸?, 6.0지진은 정말 무섭구나..", 3.0f); // 채팅
        audioSource.clip = keyboard;
        audioSource.Play(); // 채팅 타자소리
        yield return new WaitForSeconds(3.0f);
        audioSource.Stop();
        yield return new WaitForSeconds(1.0f); // 0.3초 기다림
        StartCoroutine(SizeDown(SurpriseAhri)); // 아리 채팅 꺼짐, 뽁 소리 
        yield return new WaitForSeconds(1.0f);

        NarrationText.text = "";
        NarrationBox.SetActive(true);
        NarrationText.DOText("10초 후 자동으로 체험을 종료합니다.", 3.0f);
        yield return new WaitForSeconds(10.0f);
        NarrationBox.SetActive(false);

        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("Re_Celect_DongJin_EarthQuake");
    }
}
