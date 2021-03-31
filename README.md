# C_Earthquake_VR
#6. 어린이 안전교육(지진 체험_VR)

- 시현 동영상(모바일), .apk 첨부

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 1. 개발 계기

```
2019년 동계계절수업 VR(모바일) Unity로 개인 개발.
방학 후 동계인턴에 참가(8주).
인턴에서 개발한 2번 째 작품은 어린이 안전교육 체험(VR)이다.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 2. 작품 소개

```
Unity를 이용해 게임 개발.
이 작품은 게임 보다는 말 그대로 체험을 할 수 있게 만들었다.
어린이들이 영상이나 이미지가 아닌 좀 더 흥미로울 수 있게 
Cardboard를 끼고 지진의 강도(4.0, 5.0, 6.0)를 체험하고
각 강도에 맞는 피해 등 교육 및 예방을 할 수 있다.

장르 : 체험.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 4. 구현한 것

```
- 카메라의 흔들림(Inspector 조정 등).
- 카메라의 이동(학교 안과 밖).
- 이펙트(벽, 땅에 생기는 금 등).
- 유리 창의 깨짐(코드 변경 등).
- Etc(Bgm, Particle, Animation).
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 5. 플레이 방법

- 안드로이드 핸드폰 + Cardboard = 게임 플레이 가능.

```
선택 : Cardboard를 낀 상태에서 커서게이지로 버튼, 체험하고 싶은 강도 등 2초간 응시. 
```

![녹화_2021_03_31_15_37_22_693](https://user-images.githubusercontent.com/81169838/113100922-06ceba00-9237-11eb-9fe7-3a946e65302f.gif)

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 6. 게임

- 앱 실행 후 첫 화면

![녹화_2021_03_31_15_40_45_945](https://user-images.githubusercontent.com/81169838/113101315-878db600-9237-11eb-9e72-f211444e7903.gif)

```
원하는 강도 선택 -> 각 강도체험 시작.
종료 -> 어플 종료.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 4.0 강도

![녹화_2021_03_31_15_50_56_429](https://user-images.githubusercontent.com/81169838/113102372-ebfd4500-9238-11eb-9c3b-9ac67978b7ed.gif)

```
4.0 강도 선택 -> 설명 Narration + 책상, 전등 등 흔들림 + 시계, TV의 떨어짐.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 5.0 강도

![녹화_2021_03_31_16_03_48_445](https://user-images.githubusercontent.com/81169838/113103807-b5282e80-923a-11eb-9364-51f623f93c5e.gif)

```
5.0 강도 선택 -> 4.0강도 + 카메라의 흔들림↑ + 유리 창의 깨짐.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 6.0 강도

![녹화_2021_03_31_16_07_14_12](https://user-images.githubusercontent.com/81169838/113104174-31227680-923b-11eb-9bbe-6e0f29d0904d.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_03_31_16_12_39_337](https://user-images.githubusercontent.com/81169838/113104958-0d136500-923c-11eb-886a-c41087f91b6c.gif)

```
6.0 강도 선택 -> 5.0강도 + 카메라의 흔들림↑ + 건물 벽에 금 -> 카메라 이동 -> 땅에 금 + 나무와 차의 기울임.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 다른 체험하기

![녹화_2021_03_31_16_18_18_550](https://user-images.githubusercontent.com/81169838/113105656-c8d49480-923c-11eb-8b1d-f60576141398.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_03_31_16_16_56_903](https://user-images.githubusercontent.com/81169838/113105481-93c84200-923c-11eb-8668-5e52eee5fb48.gif)

```
Narration이 끝나고 10초 후 자동으로 씬 이동 ---------------------↘
                                                                 -> 강도 재선택씬 -> 체험 선택.
중간에 다른 체험을 하고 싶으면 칠판 위 '다른 체험하러 가기' 선택---↗
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 카메라의 흔들림

![image](https://user-images.githubusercontent.com/81169838/113107282-b3f90080-923e-11eb-91ca-b470cea7cc40.png)

```
DOTween 스크립트 -> Inspector -> 각 강도에 맞게 흔들림 조정.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 카메라의 이동

![녹화_2021_03_31_16_41_03_900](https://user-images.githubusercontent.com/81169838/113108576-14d50880-9240-11eb-8da4-70b7e2dc7898.gif)

```
MainCamera -> MainCamera 비활성화 + SecondCamera 활성화 -> SecondCamera 비활성화 + MainCamera 활성화 -> MainCamera.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

- 이펙트

![녹화_2021_03_31_16_49_33_724](https://user-images.githubusercontent.com/81169838/113109622-1d7a0e80-9241-11eb-9ee4-0e4c98322179.gif)

```
이미지의 Inspector -> Image Type에서 방향과 시작점 설정 -> StartCoroutine을 활용해 원하는 타이밍에 이펙트 발생시킴.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 7. 구현 시 문제점과 한계

```
프로젝트를 시작할 때 아무것도 없는 빈 프로젝트로 시작해야 개발하기 편하다.
하지만 이 프로젝트는 회사에서 썻던 기본 프로젝트에 덮어 개발해야 했다.
문제점은 여기서 나타나게 된다.
기본 프로젝트에는 쓸모없는 것들(최적화 X)과 Unity 버전이 낮기 때문에
불편했고 제한된 것들(기능)이 다소 많았다.
제일 큰 문제는 용량자체가 매우 컸고 Unity를 실행하거나 .apk빌드를 할 때
많은 시간이 소요 됐으며 최적화를 위해 쓸모없는 파일을 줄이거나 없앨 때
수 많은 오류가 발생하거나 튕김 현상들을 조심해야 했다.
```

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## 8. 느낀 점

```
나는 프로젝트를 잘 만들기 위해서는 기획 및 구상이 중요하고
기획 및 구상에서 필요한 설명과 자료들을 철저히 숙지하고 배워야 한다고 생각한다.
내가 알고있는 지진과 다르게 실제 지진은 더욱 무서웠다.
강도의 차이에 따라 비 정상적이게 피해가 컸고 대피요령 등 많은 것을 배웠다.
또 이 프로젝트는 어린이들의 눈높이로 만들어야 했기 때문에 상당히 애를 먹었다.
Narration의 나쁜 말투나 잔인성을 줄여야 했고,
시각적으로 표현을 많이 하는 대신 최대한 이해하기 쉽게 개발해야 했기 때문이다.
여태 만들었던 게임과는 다르게 움직이거나 행동들이 없었지만
선택만하고 체험하는 것 치고는 핵심들을 잘 파악하고 간단하게 만들었다고 생각한다.
대표님은 개발한 것들을 현장에 나가 아이들에게 보여줬을 때
"신기하고 좋아하며 재미있었다!"라는 말을 듣고 그렇게 기쁠 수 가 없었다.
프로젝트를 개발하면서 지진에 대해 공부하면서 얻었던 지식,
아이들이 즐겁게 체험했다는 것은 내게는 너무 뿌듯한 프로젝트 였던 것 같다.
```

