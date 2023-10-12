# LeeJungHwan
# 이정환 유니티 A01

## 설명
1. 이번 주 내내 감기에 걸린 바람에 완성하지 못했습니다. 대신 다양한 기능을 구현해보는데 집중하여 시도를 많이 해봤습니다.
2. 삭제하고 다시 만들기의 반복이여서 프로젝트는 있는 게 거의 없습니다.
3. 해결한 문제들은 지금 ReadMe을 쓰면서 검토하는 와중에 갑자기 발상이 떠올라서 해결했습니다.

## 구현 사항
1. 게임을 시작하면 1초 마다 Ball을 쏘는데 이때 Ball은 오브젝트풀을 통해 구현



## 구현하려했던 시도
1. InputSystem에 Actions에서 '마우스 좌클릭'을 입력받는 Action 'Fire'을 설정하고 스크립트의 'OnFire()'를 'void OnFire(InputAction.CallbackContext callbackContext)' 이렇게 하면 좌클릭하는 좌표를 받아올 수 있지 않을까해서 'Action Properties'의 'Action Type'과 'Control Type'을 'Pose' , 'Vector2' , 'Vector3' 등으로 수정해봤지만 기존에 마우스 좌표를 받아오는  Vector3 pos = Input.mousePosition; 를 대신할 기능을 찾지 못했습니다.

InvalidOperationException: Cannot read value of type 'Pose' from control '/Mouse/leftButton' bound to action 'Player/Fire[/Mouse/leftButton]' (control is a 'ButtonControl' with value type 'float') 

이런 오류만 떠서 현재 InputSystem를 사용할 때 InputValue하고 InputAction.CallbackContext하고 차이를 알아보고 있습니다.

2. 코루틴을 사용해 일정주기마다 Raycast로 눈 앞의 물체의 Tag을 가져와 그에 따라 움직임을 바꾸게 하려했지만 코루틴을 '일시정지' 가능한 함수가 아닌 '반복'되는 함수라고 착각하는 바람에 시간 허비를 하다가 while(true)로 반복하게 했는데 이 과정에서 무슨 문제인지 유니티가 멈춰서 세이브가 날아갔습니다.
+ 윈도우 문제였습니다. 윈도우에서 사용되는 'antimalware service executable' 가 종종 컴퓨터 CPU를 잔뜩 잡아먹는 일이 있는데 타이밍이 절묘하게 겹쳤습니다.

3. 코루틴 내부에서 '정지' -> '전방 확인 Raycast' -> '움직임' 이 3가지를 반복하게 하려했는데 '움직임'은 'FixedUpdate'에서 구현하다보니 이걸 어떻게 해야하는 지 고민하다가 stateMachine 처럼 껐다키는 과정을 만들려 했는데 Trying to Invoke method: Unit.OnAttack couldn't be called. 이런 오류가 떠서 포기하고 다른 기능 구현에 집중했다
+ 지금 다시 지웠던 코드를 확인해보니 OnAttack?.Invoke(); 대신에 Invoke(nameof(OnAttack), 1.0f); 를 하고 있었습니다. 이벤트 시스템을 사용하는 데 익숙하지 않아서 벌인 실수였습니다.

4. 물체가 회전하는데 다른 물체와 충돌하면 덜덜 떨리는 현상.
+ 리지드바디를 사용해서 '이동'을 구현했는데 '회전'은 Transform을 사용하고 있었습니다. 
