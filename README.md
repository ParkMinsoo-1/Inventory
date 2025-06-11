# 인벤토리 기능 구현

---

## 기본 구성
![image](https://github.com/user-attachments/assets/dffdec63-ae08-46c5-8111-3babba4bad1c)

### 1. 플레이어 정보
- 플레이어의 체력, 이름, 레벨을 표시
  
### 2. 스테이터스
- 플레이어의 주요 스탯을 확인할 수 있는 UI 제공
- 플레이어의 공격력, 체력, 방어력, 치명타 표시
![image](https://github.com/user-attachments/assets/c19143de-09dc-493c-ad10-86472c1fe47d)
  
### 3. 인벤토리
- 인벤토리 UI를 통해 아이템 확인 및 장착 가능
- 아이템 선택 시 상세 정보 표시
![image](https://github.com/user-attachments/assets/613bc78a-69ab-4c0a-b51d-d744ff8cf36f)

- 장착된 아이템에는 "E" 마크 표시
![image](https://github.com/user-attachments/assets/2789d253-9332-4783-b0c8-2416026b957c)

---
## 주요 기능 정리
### 아이템 데이터 관리
- ScriptableObject를 활용해 아이템 데이터 관리
- 아이템 타입
  - Consumable (소모 아이템)
  - Equipable (장착 아이템)
    - Weapon
    - Armor
    - Helmet
    - Boots

- 장비는 종류(Weapon, Armor, Helmet, Boots)별로 한 개만 장착 가능하도록 설계
(※ 기능적으로 구현은 아직 완료되지 않음)

---
## 향후 개선 및 해결 과제
- 장비 장착 시 캐릭터의 능력치에 반영되는 기능 구현 필요
- 장비 장착/해제 시스템
  현재 List로 장착 아이템 관리
  LINQ를 활용해 동일한 종류의 기존 장비가 있을 경우 자동으로 해제 후 새 장비 장착
  해당 로직은 코드상 구현되어 있으나, 실제 동작 테스트는 미완료



