# 리그 오브 레전드 클론

리그 오브 레전드 소환사의 협곡 모드를 복제합니다.


### Requirement
DoTweenPro 로컬 패키지 (없으면 Free 버전을 사용하세요)
[Workspace Enhancer](https://github.com/cqtd/com.cqtd.workspace.enhancer) 로컬 패키지

### Goal
1. 게임 워크플로우 비헤이비어 구현 (C# Core)
2. Patchable Database 방식으로 변경된 데이터 deploy/patch 구현
3. raw resources를 extract 해서 unity compatible asset으로 변경해 사용
4. eletron-vuetify 와 unity를 연동해서 로비는 electron, 게임 클라이언트는 유니티 사용
5. 유니티 헤드리스 서버 빌드를 통한 데디케이트 서버 네트워크 멀티플레이 기능 구현
6. 윈도우 플랫폼에서의 유니티 아키텍쳐 최소한의 보안 유지
7. 커널 드라이버단에서의 안티치트



### References
#### Extractor
- Obsidian : Resource extractor
- lol2dae : Resource format convert

#### Architecture
- LeagueSandboxClient
- EloBuddy
- EnsoulSharp

#### Unity Assets
- Standard Asset Character Controller : Unity Technologies