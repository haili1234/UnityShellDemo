# UnityShellDemo
基于Unity3D项目，利用Shell命令进行项目自动化打包。

一、操作环境：

硬件：MacBookPro     系统 ：macOS 终端

二、操作步骤：

1、编写核心Shell命令：BuildMobileApp.sh文件。 【UnityShellDemo/UnityAppBuild下】

    1.1 #设置启动Unity 应用路径（UNITY_PATH）：修改为本机需要应用打包的Unity启动应用路径
    
    1.2 #应用项目路径（根路径）（PROJECT_PATH）：修改设置为需要本机打包应用项目的所在位置
    
2、打开终端命令行。
    2.1 cd 当前.sh 文件所在文件夹           // 进入当前文件夹
    
    2.2 chmod  777  BuildMobileApp.sh    //修改文件夹权限为可读可执行
    
    2.3 ./BuildMobileApp.sh  参数1  参数2  //执行Shell命令脚本，参数一：表示平台，ios /android；参数2:表示应用版本，1.0（此参数暂时不开放）
    例如终端执行： ./BuildMobileApp.sh  ios  1.0
    
3、最终打的工程，Android：AndroidBuild/iOS：iOSBuild【二次工程文件】。
