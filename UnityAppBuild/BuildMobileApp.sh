#!/bin/bash

#设置启动Unity 应用路径
UNITY_PATH=/Applications/Unity/Hub/Editor/2020.1.9f1c1/Unity.app/Contents/MacOS/Unity
#应用项目路径（根路径）
PROJECT_PATH=/Users/animeking/Documents/Study/GitHub/UnityShellDemo
#应用日志存放路径
BUILD_LOG_PATH=${PROJECT_PATH}/build.log
#项目生成路径（暂时在引擎中写死）
DESTINATION_PATH=./UnityBuildApp

  
# Only ios & Android mobile App
if [ $1 != "ios" ] && [ $1 != "android" ]; then
  echo "Please select your mobile app platform."
  exit 1
fi

# Build App Directory
#if [ ! -d ${DESTINATION_PATH} ]; then
# mkdir ${DESTINATION_PATH}
#fi


# App Platform
if [ $1 == "ios" ]; then
  BUILD_TARGET="iOS"
  EXECUTE_METHOD=BuildShellScript.PerformiOSBuild
else
  BUILD_TARGET="Android"
  EXECUTE_METHOD=BuildShellScript.PerformAndroidBuild
fi

# App Version
if [ -z $2 ]; then
  echo "Need Unity app Version."
  exit 1
else
  BUILD_VERSION=$2
fi

# Bundle Code Version (Android). Only integer is accpected.
#BUILD_CODEVERSION=$3
#regex="^[0-9]+$"
#if ! [[ $BUILD_CODEVERSION =~ $regex ]]; then
#  echo "Bundle code version need to input an integer."
#  exit 1
#else
#  BUILD_CODEVERSION=$3
#fi

echo "应用项目开始导出......"
if [ $1 == "ios" ];then
$UNITY_PATH \
-quit \
-batchmode \
-nographics \
-projectPath  ${PROJECT_PATH} \
-buildTarget ${BUILD_TARGET}  \
-executeMethod BuildShellScript.PerformiOSBuild \
-logFile ${BUILD_LOG_PATH}
#-destinationPath ${DESTINATION_PATH}
else
$UNITY_PATH \
-quit \
-batchmode \
-nographics \
-projectPath  ${PROJECT_PATH} \
-buildTarget ${BUILD_TARGET}  \
-executeMethod BuildShellScript.PerformAndroidBuild \
-logFile ${BUILD_LOG_PATH}
#-destinationPath ${DESTINATION_PATH}
fi

echo "应用项目导出完成！"
echo "Built app on ${BUILD_TARGET} platform."


