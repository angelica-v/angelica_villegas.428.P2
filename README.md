# angelica_villegas.428.P2
 
Welcome to CS 428 Project 2 -One More Cup of Coffee
 GitHub Documentation 

Created by Angelica Villegas Salazar.

## Introduction
This is a project for Virtual, Augmented and Mixed Reality taught by Professor Andy Johnson. 

The goal was to create a VR environment that could be viewed in both Unity and in the Oculus Quest VR headset. This environment is based off a coffee shop to be located in the new CS building. I modeled my scene based on a fall/witch theme. Somedays, you need a snack/coffee before you cast spells and make potions. When walking around the scene one is able to pick up items including but not limited to, the potions, skull, cakes, cookies, and pumpkins. Additionally, if the user touches either the coffee maker screen or the over dials an new coffee cup or a new pie (cherry/pumpkin) is spawned into the game. MakeHuman and Mixamo, an animated avatar was created. If you touch the avater she mutters a spell. Additionally, the cauldron/potion, the oven, and the cat all make noises when you approach them and all potions make a clinking noise when you grab or touch them. 

For more information please visit the [project website](https://sites.google.com/uic.edu/cs428-angelica/project-2).

## Software Requirements

* Unity 
  - [version 2021.3.6f1](https://unity3d.com/unity/whats-new/2021.3.6) 
* [Unity Hub](https://unity3d.com/get-unity/download)
* VRTK
  - version 4
  
  
## Installation Instructions

1. Download the newest version of Unity Hub.
1. Once the download is complete, Open Unity Hub, navigate to the left hand bar and click on the **Installs** tab
1. If this is your first install of Unity Hub/Unity there will be no installs listed. To install the correct version on Unity:
    1. Navigate to **Install Editor** in the top left
    1. Navigate to the **Archive** tab in the top bar
    1. In the statment in this tab, click on the hyper link that says **download archive**
    1. Navigate to the correct version of Unity(2021.3.6f1)
    1. Click on the **Unity Hub** button to download this version to Unity Hub. 
    1. This will prompt Unity Hub to open and then will open an **Install** page with the version listed. 
        1. Under **Platforms** make sure to select **Android Build Support** if you want to build to an Oculus. 
        1. Under **Documentation** make sure to select **Documentation**
    1. If you forget to check any modules above you can do it after Unity is installed. 
    1. Click on the **Install**
    1. The correct version should now be installing
1. Now that the correct version of Unity is installed, you can move forward in the project

## Project Instructions
1. Download the project from Github and unzip the file
1. In **Unity Hub** ensure the version is correct click **open** and click on the now unzipped main folder
1. After opening, there should be a blank scene
1. Navigate to the **Assets** folder
1. Inside the folder there is a scene called **Fall Scene** drag and drop into the heirarchy
1. Delete the  **Untitled Scene**, **Fall Scene** should be the only scene in the heirarchy.
1. Now you should have the scene fully loaded.
  * For playing scene in Unity
     1. Ensure that **CameraRigs.SpatialSimulator** is enabled and **UnityXRPluginFramework** is disabled. One can do this by clicking **Toggle Active State**
     1. Click play on the top hand bar.
     1. To navigate use keys **W** to move forward, **S** to move back, **D** to move left, **A** to move left
     1. Press keys **2** and **3** to select the right or left hand respectively.
     1. Then uses **W**, **S**, **A**, **D** to move the hand/controller to the right place. 
     1. Press on the mouse if you wish to press on an item.
     1. If you are done using the hands/controller press key **1**
  * For playing scene on Oculus Quest Headset
     1. Ensure that **UnityXRPluginFramework** is enabled and **CameraRigs.SpatialSimulator** is disabled. One can do this by clicking **Toggle Active State** 
     1. Under **File** in the top bar, open **Build Settings**
     1. Connect the Oculus Quest to the computer with Unity via cord
     1. Click on **Android** and under **Run Device** make sure to select the Oculus device being used/device that is connected
     1. Ensure that permissions are allowed on the Oculus to connect to computer
     1. Click ** Build And Run**
     1. Once you set up any boundaries need it should be running!
     1. If not, on the Oculus go to **Apps** and under the filter where it says **All** click and scroll down and click where it says **Unknown Sources**.
     1. Click on **P2.angelica_villegas salzar**. The application should now be running!
     1. Navigate by either walking the scene, or teleporting using the joystick in the righthand (move green dot to place and click to move)
     1. To pick up/drop off items, click the side buttons as if you are grabbing the item. 
     
     
 Congrats!! You should now be able to navigate through the scene that was created!
