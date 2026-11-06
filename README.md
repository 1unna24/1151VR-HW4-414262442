# Unity 飛機遊戲專案內容
目前場景為 **SampleScene**，以飛機作為玩家控制物件，包含以下物件：
- Plane（玩家飛機）
- Main Camera（主攝影機）
- Directional Light（方向光）
- Global Volume（全域後製效果）
- Cloud_Obstacle_01（雲朵障礙物）
- GoldCoin（金幣）

## 製作流程與相關操作

### 1. Unity 專案建立
- 開啟 Unity Hub
- 建立 Unity 3D 專案
- 建立遊戲場景 SampleScene
- 匯入 Low Poly Cartoon Mini Pack Free 素材

### 2. Unity 場景與物件配置
- 建立飛機物件並設定 Transform
- 配置雲朵障礙物
- 放置金幣物件
- 設定飛機、雲朵及金幣的 Collider
- 調整物件的位置、大小與場景配置

### 3. 飛機控制功能
- 飛機持續向前飛行
- 使用鍵盤控制飛機左右轉向
- 使用鍵盤控制飛機上下移動
- 飛機碰到雲朵時播放碰撞音效
- 發生碰撞後飛機仍持續飛行

### 4. 金幣旋轉與收集音效
- 使用 `CoinRotate.cs` 控制金幣持續旋轉
- 金幣沿著垂直軸旋轉
- 飛機碰到金幣時播放收集音效
- 金幣保留在場景中，不會消失

### 5. 音效設定
- 飛機開始遊戲時播放引擎音效
- 引擎音效持續循環播放
- 飛機碰到雲朵時播放碰撞音效
- 飛機碰到金幣時播放收集音效

### 6. C# 腳本
- `PlaneController.cs`：控制飛機移動及碰撞音效
- `CoinRotate.cs`：控制金幣旋轉及收集音效

### 5. 作業繳交
- **GitHub：** https://github.com/1unna24/1151VR-HW4-414262442
- **YouTube：** https://youtu.be/fjwdkxjOCyg
