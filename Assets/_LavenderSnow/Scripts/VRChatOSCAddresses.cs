namespace OSCPhoto
{
    public static class VRChatOSCAddresses
    {
        public const string InputJump = "/input/Jump";
        public const string InputMoveForward = "/input/MoveForward";
        public const string InputMoveBackward = "/input/MoveBackward";
        public const string InputMoveLeft = "/input/MoveLeft";
        public const string InputMoveRight = "/input/MoveRight";
        public const string UserCameraMode = "/usercamera/Mode"; // カメラモードの取得/設定
        public const string UserCameraPose = "/usercamera/Pose"; // カメラの位置と回転を取得/設定する
        public const string UserCameraClose = "/usercamera/Close"; //カメラを閉じる
        public const string UserCameraCapture = "/usercamera/Capture"; //写真を撮る
        public const string UserCameraCaptureDelayed = "/usercamera/CaptureDelayed"; //タイマーで写真を撮る
        //トグル
        public const string UserCameraShowUIInCamera= "/usercamera/ShowUIInCamera"; //UIマスクを取得/切り替える
        public const string UserCameraLock = "/usercamera/Lock"; //ロックの取得/切り替え
        public const string UserCameraLocalPlayer = "/usercamera/LocalPlayer"; //ローカルプレーヤーマスクを取得/切り替える
        public const string UserCameraRemotePlayer = "/usercamera/RemotePlayer"; //リモート プレイヤー マスクを取得/切り替える
        public const string UserCameraEnvironment = "/usercamera/Environment"; //環境マスクの取得/切り替え
        public const string UserCameraGreenScreen = "/usercamera/GreenScreen"; //グリーンスクリーンの取得/切り替え
        public const string UserCameraSmoothMovement = "/usercamera/SmoothMovement"; //スムージング動作の取得/切り替え
        public const string UserCameraLookAtMe = "/usercamera/LookAtMe"; //Look-At-Me 動作の取得/切り替え
        public const string UserCameraAutoLevelRoll = "/usercamera/AutoLevelRoll"; //自動レベルロール動作の取得/切り替え
        public const string UserCameraAutoLevelPitch = "/usercamera/AutoLevelPitch"; //自動レベルピッチ動作の取得/切り替え
        public const string UserCameraFlying = "/usercamera/Flying"; //飛行の取得/切り替え
        public const string UserCameraTriggerTakesPhots = "/usercamera/TriggerTakesPhotos"; //取得/切り替えトリガーで写真を撮影
        public const string UserCameraDollyPathsStayVisible = "/usercamera/DollyPathsStayVisible"; //アニメーション中にドリーパスを表示/非表示にする
        public const string UserCameraCameraEars = "/usercamera/CameraEars"; //カメラからの音声を取得/切り替え
        public const string UserCameraShowFocus = "/usercamera/ShowFocus"; //フォーカスオーバーレイを取得/切り替える
        public const string UserCameraStreaming = "/usercamera/Streaming"; //スパウトストリームの取得/切り替え
        public const string UserCameraRollWhileFlying = "/usercamera/RollWhileFlying"; //飛行中のロール動作を取得/切り替える
        public const string UserCameraOrientationIsLandscape = / "usercamera/OrientationIsLandscape"; //方向を取得/切り替える
        //スライダー
        public const string UserCameraZoom = "/usercamera/Zoom"; //ズームスライダーを取得/設定する
        public const string UserCameraExposure = "/usercamera/Exposure"; //露出スライダーを取得/設定する
        public const string UserCameraFocalDistance = "/usercamera/FocalDistance"; //焦点距離スライダーを取得/設定する
        public const string UserCameraAperture = "/usercamera/Aperture"; //絞りスライダーを取得/設定する
        public const string UserCameraHue = "/usercamera/Hue"; //グリーンスクリーンの色相スライダーを取得/設定する
        public const string UserCameraSaturation = "/usercamera/Saturation"; //グリーンスクリーンの彩度スライダーを取得/設定する
        public const string UserCameraLightness = "/usercamera/Lightness"; //グリーンスクリーンの明度スライダーを取得/設定する
        public const string UserCameraLookAtMeXOffset = "/usercamera/LookAtMeXOffset"; //LAM Xオフセットスライダーを取得/設定
        public const string UserCameraLookAtMeYOffset = "/usercamera/LookAtMeYOffset"; //LAM Yオフセットスライダーを取得/設定
        public const string UserCameraFlySpeed = "/usercamera/FlySpeed"; //飛行速度スライダーを取得/設定する
        public const string UserCameraTurnSpeed = "/usercamera/TurnSpeed"; //回転速度スライダーを取得/設定する
        public const string UserCameraSmoothingStrength = "/usercamera/SmoothingStrength"; //スムージング強度スライダーを取得/設定する
        public const string UserCameraPhotoRate = "/usercamera/PhotoRate"; //ドリー写真キャプチャレートスライダーを取得/設定する
        public const string UserCameraDuration = "/usercamera/Duration"; //ドリー持続時間スライダーを取得/設定する
    }
}