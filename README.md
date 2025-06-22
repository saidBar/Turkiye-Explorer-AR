# My AR Landmark Explorer App

This repository contains the source code for the AR Landmark Explorer mobile application built with Unity.

## How to Get the Project Source Code

There are a few ways to get this project onto your computer. The recommended method depends on whether you plan to contribute changes back to the project.

### Option 1: Clone with Git (Recommended for Contributors)

This method is best if you have Git installed and plan to make changes to the project yourself, and potentially push them back to this repository.

#### Prerequisites:
* **Git Installed:** If you don't have Git, download it from [git-scm.com](https://git-scm.com/downloads).
* **Unity Hub Installed:** Download Unity Hub from [unity.com](https://unity.com/download).

#### Steps:

1.  **Open your Terminal or Git Bash** (on Windows) or **Command Line Prompt**.
2.  **Navigate to the directory** where you want to store your Unity projects. For example:
    ```bash
    cd Documents/UnityProjects
    ```
    (You can replace `Documents/UnityProjects` with any path you prefer.)
3.  **Clone the repository:** Copy the HTTPS URL of this GitHub repository (you can find it by clicking the green `< > Code` button on the repository page). Then, run the following command, replacing the URL with the actual one:
    ```bash
    git clone [https://github.com/your-username/your-repo-name.git](https://github.com/your-username/your-repo-name.git)
    ```
    (Replace `https://github.com/your-username/your-repo-name.git` with the actual URL you copied).
4.  **Wait for the download to complete.** Git will download all project files into a new folder named after the repository (e.g., `my-ar-landmark-explorer-app`).

### Option 2: Download as a ZIP File (Quick Snapshot - Not for Collaboration)

This is the simplest way to get the project files if you just want to view the code or test the app without using Git for version control. **This method is NOT recommended if you plan to make changes and contribute back to the repository.**

#### Prerequisites:
* **Unity Hub Installed:** Download Unity Hub from [unity.com](https://unity.com/download).

#### Steps:

1.  Go to the repository page on GitHub.com.
2.  Click the green **`< > Code`** button.
3.  Select **`Download ZIP`**.
4.  Save the `.zip` file to your desired location on your computer.
5.  **Extract (unzip) the downloaded file** to a new folder.

---

## How to Open the Project in Unity

Once you have the project files on your computer (using any of the options above):

1.  **Open Unity Hub.**
2.  Click the **`Add Project`** button (or `Open` depending on your Unity Hub version).
3.  **Navigate to the root folder of the downloaded/cloned project.** This is the folder that contains the `Assets`, `ProjectSettings`, and `Packages` folders.
4.  **Select this root folder.**
5.  Unity Hub will add the project to its list. Select it and choose the appropriate Unity Editor version (ideally the one used to create the project, or a compatible version) to open it.

---

## Building and Running the App on an Android Device

Once the project is open in Unity, you can build and run it on an Android device:

#### Prerequisites:
* An ARCore-supported Android device.
* Developer Options and USB Debugging enabled on your Android device.
* Android SDK & NDK installed via Unity Hub.

#### Steps:

1.  **Connect your Android device** to your computer via USB.
2.  In Unity, go to `File` > `Build Settings...`.
3.  Ensure `Android` is selected as the platform. If not, select it and click `Switch Platform`.
4.  Confirm that `WelcomeScene` and `LandmarkScene` are checked under "Scenes In Build".
5.  Click `Player Settings...` at the bottom left.
    * Under `Android` tab > `Other Settings` > `Configuration`, ensure `Scripting Backend` is `IL2CPP` and `ARM64` is checked under `Target Architectures`.
    * Under `Other Settings` > `Rendering`, ensure `Vulkan` is **NOT** in the `Graphics APIs` list if your device has an API Level lower than 29 (e.g., Android Pie 9). `OpenGLES3` should be present.
6.  Close Player Settings.
7.  Click `Build And Run` in the Build Settings window.
8.  Unity will build the `.apk` and install it on your connected device.

---

Enjoy exploring!
