# 버튼잡기게임(C# 코딩)

25017050 안정찬

## 개요

-C# 프로그래밍학습

-핵심기능: 버튼에 마우스 올리면 위치 변경, 제목에 버튼 좌표 및 점수 표시, 성공 및 실패시 점수 + -, 성공 실패시 창 나타나기 및 버튼 크기 변화, 점수가 0점일떄 재도전 질문 

-화면구성: 잡을 버튼, 점수, 버튼의 좌표, 성공 실패시 알림창, 재도전 창

## 실행화면
-1단계코드의실행스크린샷
<img width="867" height="528" alt="image" src="https://github.com/user-attachments/assets/f09d164d-b0a2-47d2-96dd-8973d7ce49c5" />

-2단계코드의실행스크린샷

<img width="990" height="568" alt="스크린샷 2026-03-12 170919" src="https://github.com/user-attachments/assets/8ea2c85a-3e18-4851-95a8-221851f17529" />

<img width="954" height="506" alt="image" src="https://github.com/user-attachments/assets/c4373549-b401-471b-987a-2bf016e55dcf" />

-3단계코드의실행스크린샷

<img width="535" height="264" alt="스크린샷 2026-03-12 171108" src="https://github.com/user-attachments/assets/ff8e5719-71fd-48dd-941a-4427c05d45f6" />

버튼 축소 및 점수 증가

<img width="335" height="127" alt="스크린샷 2026-03-12 171150" src="https://github.com/user-attachments/assets/a1a9be91-da95-43ac-aa03-53ad898d5cf8" />

-4단계코드의실행스크린샷

<img width="1002" height="567" alt="image" src="https://github.com/user-attachments/assets/ad9604f7-b0c6-4b8c-9ef4-6e89e9a8525c" />

## 구현 시 힘들었던 점

버튼을 랜덤하게 이동시키면서 화면 밖으로 나가지 않게 하는 부분 에서 조금의 시행착오가 있었다.

점수를 올리고 깎는 부분, 좌표의 변경은 간단했지만, 그 값을 폼 제목(this.Text)에 실시간으로 반영하는 부분에서 힘들었다.

처음 만들떄 변수 선언을 버튼에 마우스가 올라갔을떄의 코드 에만 쓸수 있게 선언해서 성공 및 실패시 바로 점수가 반영을 못하는 상황이 있었다.

검색을 통해 버튼 자체의 위치를 나타내는 코드를 알게되어 해결할 수 있었다.

단순 알림(MessageBox.Show)은 간단했지만, 다시하기 버튼 같은 선택지를 주려면 MessageBoxButtons.YesNo와 결과 처리(DialogResult)를 알아야 했습니다.

Copilot의 도움으로 MessageBox를 더 잘 쓸 수 있게 되었다.

다 만들고 난 뒤 직접 게임을 해 보면서 너무 말이 안되는 것 같다는 생각이 들었다.

특히 화면을 키울 수록 절대 점수를 낼 수 없어 보였다.

그래서 다음에는 버튼이 랜덤으로 움직이지만 마우스가 갔을 떄 말고 일정 시간이 지나면 자동으로 움직이거나 하는 등의 형식으로 만들어 보고 싶다.

또 성공,실패시 창이 뜨는데 반드시 확인 버튼을 눌러야 하는 점도 아쉬웠다. 잠깐뜨고 바로 사라지거나 구석에 뜨기만 하고 확인을 누를필요 없는 식의 방식으로 만들어 보는 게 좋을 것 같다.


