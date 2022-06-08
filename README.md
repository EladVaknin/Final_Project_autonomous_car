# Autonomous Car - Final Project
Final Project - Ariel University Department of Computer Science 2022.
 Instructed by Professor Boaz Ben Moshe.
## Introduction :
The world is progressing towards autonomous vehicles with autonomous control, one of the main systems required for the field is a reliable system that can scan its environment and give an accurate indication of when an accident danger occurs and prevent it by braking / acceleration.

For this to happen - the system needs to be sensitive and accurate and know how to scan the environment in real time and act accordingly - which is why we developed the tool we chose. 

**Project goal :** the project is designed to develop a solution for navigation in autonomous vehicles (in a simulator or a real car), emphasizing the reliability of the autonomous software and in addition to conducting a review of the existing technologies on the market and comparing them.


## Part 1 - Overview : 

The following review was written for the purpose of promotion
And development of research in the field of autonomous vehicles,
In the review, we will compare **ARCore** - a platform
For building augmented reality experiences by Google and **RTAB map** - RGB-D based SLAM approach, stereo and Lidar Graph
Closing detector.
The goal - familiarity with the platforms and the technology behind it
The same, advantages and disadvantages of each of the platforms,
Knowledge of the hardware required for proper use of platforms
And classifying the use of platforms as needed.

**For the full review:** https://github.com/EladVaknin/Final_Project_autonomous_car/tree/main/Overview


## Part 2 - Augmented Reality APP :

After performing the above review, we chose to focus on Google's ARcore technology and use it to develop a mobile application that will be a kind of car simulator - the application knows how to identify surfaces and distinguish between them, the application knows to detect potential transitions (we created a data set and taught the application to identify .
In further development the application will know how to create a trajectory and an object that will execute the trajectory.
With the help of the route that was opened and the features we developed, the application will serve as a simulator for autonomous driving.

The application was developed in the **Unity** work environment with the **AR Foundation** and **ARCore XR Plug-in** libraries.

**Exampels**:
Surface identification and modeling: 
![](https://github.com/EladVaknin/Final_Project_autonomous_car/blob/main/gifs/BNTS3X_f4f2deded75a5dbec8ac68f913ecfd8e_00-00-00_00-00-07_2.gif)
Detection of potential passages (eg door):
![](https://github.com/EladVaknin/Final_Project_autonomous_car/blob/main/gifs/BNTS3X_b9e2d58bcf2b1f9acab5c14d0cf89ee8_00-00-00_00-00-06_2.gif)





 


**How to install ?! :**
1. Make sure your Android device is listed https://developers.google.com/ar/devices?hl=en
2. Make sure your device supports OpenGLES3 and Android 8.0 and above.
3. Download the APK file from Builds folder.
4. Allow access to the camera when using the application.


## Technological schema:
![image](https://user-images.githubusercontent.com/74238558/172565370-33c727ce-bc73-41a3-8397-90f58447a97f.png)


## Participants : 
- Avigael Abitbol
- Afik Peretz
- Elad Vaknin
