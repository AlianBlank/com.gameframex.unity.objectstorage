<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X Object Storage

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.objectstorage)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.objectstorage)](https://github.com/GameFrameX/com.gameframex.unity.objectstorage/releases)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · QQ Group: 467608841 / 233840761

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## Project Overview

**Object Storage Component** - Provides base interfaces and abstractions for object storage (cloud file storage) operations. This package defines the core contracts for uploading files and directories to object storage services, with provider-specific implementations available as separate packages.

### Features

- `IObjectStorageManager` interface for storage manager initialization
- `IObjectStorageUploadManager` interface for file/directory upload operations
- `BaseObjectStorageUploadManager` abstract base class for custom implementations
- `ObjectStorageUploadFactory` static factory for creating upload manager instances

## Quick Start

### Installation

Choose one of the following methods:

1. Add the following to the `dependencies` section of your project's `manifest.json`:
   ```json
   {"com.gameframex.unity.objectstorage": "https://github.com/AlianBlank/com.gameframex.unity.objectstorage.git"}
   ```
2. Use `Git URL` in Unity's Package Manager: https://github.com/AlianBlank/com.gameframex.unity.objectstorage.git
3. Download the repository and place it in your Unity project's `Packages` directory.

### Usage Examples

```csharp
using GameFrameX.ObjectStorage.Runtime;

// Create and initialize an upload manager instance
IObjectStorageUploadManager uploadManager = ObjectStorageUploadFactory.Create<YourCustomUploadManager>(
    "your_access_key", "your_secret_key", "your_bucket_name");

// Set the target storage path
uploadManager.SetSavePath("desired/upload/path");

// Upload a local directory
uploadManager.UploadDirectory("local/directory/to/upload");
```

## Platform Support

| Platform | Supported |
|----------|-----------|
| Windows | Yes |
| macOS | Yes |
| Linux | Yes |
| Android | Yes |
| iOS | Yes |

## Documentation & Resources

- [Documentation](https://gameframex.doc.alianblank.com)
- [GitHub Repository](https://github.com/GameFrameX/com.gameframex.unity.objectstorage)

## Community & Support

- QQ Group: Join via [QR Code](https://qm.qq.com/cgi-bin/qm/qr?k=ikT9gA5m2sKwOyNOfYmQvSAPK_c3GmD6)

## License

This project is licensed under the terms of the [LICENSE](LICENSE) file.
