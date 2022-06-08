![image](https://user-images.githubusercontent.com/74238558/172580322-74437139-6a6c-4bee-8e47-1d3d0cbfbdaa.png)

# Overview - Final Project

### Introduction :
 The following document was written for the purpose of promoting and developing research in the field of autonomous vehicles, in the document we will make a comparison between ARCore - platform for building augmented reality experiences by Google and RTAB-Map - RGB-D, Stereo and Lidar Graph-Based SLAM approach closure detector.

Goal - Familiarity with the platforms and the technology behind them, advantages and disadvantages of each of the platforms, knowledge of the hardware required to use the platforms correctly and classification of use of the platforms as needed.


The main investment in this project was to gain sufficient knowled gaining sufficient knowledge in order to build an application that will know how to map areas, identify obstacles and in the distant future will also know how to mobile itself in autonomous driving.

 ARCore used with basic android phone &  
RTAB-Map with Intel RealSense camera L515  
RGB-D camera.


In this project we were involved in building an ARCORE based application that will know how to map spaces and guide us by arrow to where we need to move to get effective mapping, also the system should detect doors or remember objects or places we have marked.

Our app is based on ARCore technologies for android operating system, with some added features.

ARcore can create depth maps, images that contain data about the distance between surfaces from a given point, using the main RGB camera from a supported device.

For this project we will install and use RTAB-Map to generate a 3D point cloud of an environment using only the Intel RealSense L515 Camera. We will not use any external odometry measurements or any external sensors.


### _RGB-D Cameras_


RGB-D stands for Red Green Blue - Depth, or Color and Depth. An RGB-D Camera is a 3D camera that outputs an image with color and depth information at the pixel level. For the most part, these cameras use a pair of stereo IR (Infrared) cameras and a color (RGB) camera. They are also equipped with an IR projector which projects a pattern onto the environment which is used to get more accurate depth information than a standard stereo camera. Until recently, RGB-D cameras had some weaknesses that limited their practicality in the real world. They had a very limited depth range, and were rendered nearly useless when used outdoors. This was caused by the IR from the projector getting washed out by the ambient IR from sunlight.

The L515 is a revolutionary solid state LiDAR depth camera which uses a proprietary MEMS mirror scanning technology, enabling better laser power efficiency compared to other time‑of‑flight technologies. With less than 3.5W power consumption for depth streaming, the Intel RealSense LiDAR camera L515 is the world’s most power efficient high‑resolution LiDAR camera.




### _RTAB-Map_


RTAB-Map (Real-Time Appearence-Based Mapping) is a very powerful software package made for 3D mapping and navigating with RGB-D Cameras. There is also a ROS package that allows it to be used seamlessly in ROS. RTAB-Map uses the depth images received from the camera to perform Graph-Based SLAM, generating a dense, color point cloud and odometry of the camera.


It is also able to do loop closure real-time, using bag of words and SIFT feature detectors.

RTAB-Map is a RGB-D, Stereo and Lidar Graph-Based SLAM approach based on an incremental appearance-based loop closure detector. The loop closure detector uses a bag-of-words approach to determinate how likely a new image comes from a previous location or a new location. When a loop closure hypothesis is accepted, a new constraint is added to the map’s graph, then a graph optimizer minimizes the errors in the map. A memory management approach is used to limit the number of locations used for loop closure detection and graph optimization, so that real-time constraints on large-scale environnements are always respected.




**_ARCore ( Augmented Reality Core) –_**


ARCore uses three key capabilities to integrate virtual content with the real world as seen through your phone's camera:

•Motion Tracking: When you use an AR-based application, you are asked first to open your camera and sometimes also asked to move your phone. This is done to capture your surrounding and detect distinct features from it also called feature points. ARCore uses SLAM (Simultaneous Localization And Mapping) to understand the position of your phone relative to your surrounding. Once the feature points are detected, SLAM uses them to compute the change in location. To compute the position and orientation of the phone relative to its surrounding, over time, the visual information detected by the camera is combined with the measurements of the IMU (Inertial Measurement Unit: an electronic device that measures and reports a body’s specific force, angular rate, and sometimes the orientation of the body, using a combination of accelerometers, gyroscopes, and sometimes magnetometers).

•Environmental Understanding: As we already discussed the feature points, ARCore looks for clusters of these feature points that lie on the same horizontal or vertical surfaces like a table or a door and makes this information available to your app. Later, this information is used to place 3D objects on flat surfaces.

•Light Estimation: To make virtual content more realistic, it is  always a good choice to consider light as one of the significant areas to work on. As the light gets reflected in different directions after falling onto an object making the environment pleasing to the eyes of a viewer, the concept of light estimation tries to do the same with the 3D objects. After capturing images of the surrounding, ARCore provides information about the average intensity and color correction of the images which lets a developer light a virtual object under the same conditions as the surrounding environment.



**Conclusion**

In this paper, we have presented a an app based on ARcore technologies and RTAB-Map mapping -based

on SLAM algorithm, and within both of indoor and outdoor environment, different observations were made.

We have tested RTAB-MAP and our app based on ARcore in several situation.

The RTAB_Map based on Slam alghorithm used with real-sense camera is able to map in the dark while our app based on ARcore doesn't, however the opposite is not true – RealSense camera has difficulties mapping in daylight while ARcore has no problem with that.

Moreover, our app based on  RTAB-Map  could not provide good trajectory or distance estimates while ARcore is able to give the exact distance and trajectory. Few tests show that RTABMAP used with real-sense camera is better on certain conditions. We have validated the whole developments under camera & phones platform within comparasion  in indoor and outdoor environment.

**Comparasion**
![](https://github.com/EladVaknin/Final_Project_autonomous_car/blob/main/gifs/BNTS3X_b9e2d58bcf2b1f9acab5c14d0cf89ee8_00-00-00_00-00-06_2.gif)

