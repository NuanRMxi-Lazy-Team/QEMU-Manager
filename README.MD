# QEMU Manager

QEMU Manager 是一个简单的 QEMU 前端界面，用于管理和启动虚拟机。它提供了图形化界面，方便用户配置和启动 QEMU 虚拟机，而无需手动编写复杂的命令行参数。

## 功能特点

- **图形化界面**：通过直观的图形界面配置虚拟机。
- **虚拟机管理**：启动、停止和管理虚拟机。
- **配置文件支持**：保存和加载虚拟机配置。
- **热切换设备**：动态切换 CD-ROM 和 USB 设备。
- **QEMU Monitor**：启动时打开 QEMU Monitor，方便实时管理虚拟机。

## 安装

### 从源代码编译

1. **克隆仓库**：

   ```bash
   git clone https://github.com/NuanRMxi-Lazy-Team/QEMU-Manager.git
   cd QEMU-Manager
   ```

2. **安装依赖**：

   确保你已经安装了 .NET SDK。你可以从 [.NET 官方网站](https://dotnet.microsoft.com/download) 下载并安装。

3. **编译项目**：

   ```bash
   dotnet restore
   dotnet build
   ```

4. **运行程序**：

   ```bash
   dotnet run
   ```

### 使用预编译的二进制文件

1. **下载最新版本**：

   访问 [Releases 页面](https://github.com/NuanRMxi-Lazy-Team/QEMU-Manager/releases) 下载最新版本的 QEMU Manager。

2. **解压并运行**：
   解压下载的文件，并运行 `Manager.exe`。

## 使用方法

### 启动虚拟机

1. **配置虚拟机**：

   - 输入 QEMU 可执行文件路径。
   - 输入 CD-ROM (ISO) 文件路径。
   - 输入虚拟硬盘文件路径。
   - 选择启动方式（CD-ROM 或硬盘）。
   - 配置其他选项（如内存大小、CPU 模型、网卡类型等）。

2. **启动虚拟机**：
   - 点击“启动虚拟机”按钮。

### 停止虚拟机

- 点击“终止 QEMU”按钮。

### 热切换设备

- 点击“热切换管理器”按钮，打开热切换管理器界面。

- 输入 CD-ROM 或 USB 设备路径，并点击“附加”按钮。

### 保存和加载配置

- 点击“保存配置”按钮，保存当前配置到文件。

- 点击“加载配置”按钮，加载配置文件。

## 命令行支持

QEMU Manager 支持通过命令行参数快速加载配置文件并启动虚拟机：

```bash
Manager.exe /load "C:\path\to\your\config.cfg"
```

## 贡献

欢迎贡献代码！请遵循以下步骤：

1. **Fork 仓库**。

2. **创建新分支**：

   ```bash
   git checkout -b feature/your-feature
   ```

3. **提交更改**：

   ```bash
   git commit -m "Add some feature"
   ```

4. **推送到分支**：

   ```bash
   git push origin feature/your-feature
   ```

5. **创建 Pull Request**。

## 许可证

QEMU Manager 采用 [Creative Commons Attribution-NonCommercial (CC BY-NC)](https://creativecommons.org/licenses/by-nc/4.0/) 许可证。

- **非商业用途**：禁止商业用途。
- **署名**：必须注明原作者。
- **修改和分发**：允许修改和分发。

请遵守许可证条款。

## 联系方式

- **GitHub**: [NuanRMxi-Lazy-Team/QEMU-Manager](https://github.com/NuanRMxi-Lazy-Team/QEMU-Manager)
- **Email**: [starmoe@moerain.cn](mailto:starmoe@moerain.cn)

感谢你的支持！
