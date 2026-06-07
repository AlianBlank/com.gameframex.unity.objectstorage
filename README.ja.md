<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Object Storage

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.objectstorage)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.objectstorage)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>
## プロジェクト概要

**Object Storage コンポーネント** - オブジェクトストレージ（クラウドファイルストレージ）操作の基本インターフェースと抽象を提供します。このパッケージは、ファイルやディレクトリのオブジェクトストレージサービスへのアップロードに関するコアコントラクトを定義し、プロバイダー固有の実装は個別パッケージとして提供されます。

### 機能

- `IObjectStorageManager` インターフェース：ストレージマネージャーの初期化用
- `IObjectStorageUploadManager` インターフェース：ファイル/ディレクトリアップロード操作用
- `BaseObjectStorageUploadManager` 抽象基底クラス：カスタム実装用
- `ObjectStorageUploadFactory` 静的ファクトリクラス：アップロードマネージャーインスタンスの作成用

## クイックスタート

### インストール

以下のいずれかの方法を選択してください：

1. プロジェクトの `manifest.json` の `dependencies` セクションに以下を追加：
   ```json
   {"com.gameframex.unity.objectstorage": "https://github.com/AlianBlank/com.gameframex.unity.objectstorage.git"}
   ```
2. Unity の `Package Manager` で `Git URL` を使用して追加：https://github.com/AlianBlank/com.gameframex.unity.objectstorage.git
3. リポジトリをダウンロードして Unity プロジェクトの `Packages` ディレクトリに配置（自動的に読み込まれます）。

### 使用例

```csharp
using GameFrameX.ObjectStorage.Runtime;

// アップロードマネージャーインスタンスを作成して初期化
IObjectStorageUploadManager uploadManager = ObjectStorageUploadFactory.Create<YourCustomUploadManager>(
    "your_access_key", "your_secret_key", "your_bucket_name");

// アップロード先のストレージパスを設定
uploadManager.SetSavePath("desired/upload/path");

// ローカルディレクトリをアップロード
uploadManager.UploadDirectory("local/directory/to/upload");
```

## プラットフォーム対応

| プラットフォーム | 対応 |
|-----------------|------|
| Windows | はい |
| macOS | はい |
| Linux | はい |
| Android | はい |
| iOS | はい |

## ドキュメントとリソース

- [ドキュメント](https://gameframex.doc.alianblank.com)
- [GitHub リポジトリ](https://github.com/GameFrameX/com.gameframex.unity.objectstorage)

## コミュニティとサポート

- QQグループ：[QRコード](https://qm.qq.com/cgi-bin/qm/qr?k=ikT9gA5m2sKwOyNOfYmQvSAPK_c3GmD6)から参加

## ライセンス

このプロジェクトは [LICENSE](LICENSE) ファイルに定義された条件に基づいてライセンスされています。
