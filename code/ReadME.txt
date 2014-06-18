Instruction to use the code and for compilation


Required Software
-> Visual Studio 2012 
-> .NET Framework 3.5 
-> Windows 7
-> EmguCV library For OPENCV in C#
-> Aforge.NET library for MJPEG Stream Capture 2.8


Required Hardware
-> An IP camera Or
-> USB camera
-> Zigbee Module 

Instruction
-> to reduce the package size some of the library has been removed. If u want to use this code u have to download these code from their original author site.
-> Dont change the structure of the config file otherewise program will not work but u can remove the config directly using any text editor.
-> To copmile code use VS 2012 with .NET 3.5 and paste the library excutables in the "Autobots/bin/Debug" folder
	AForge.Controls.dll    nppi64_55.dll                opencv_gpuoptflow290.dll
	AForge.dll             npps64_55.dll                opencv_gpustereo290.dll
	AForge.Imaging.dll     OpenCL.dll                   opencv_gpuwarping290.dll
	AForge.Math.dll        opencv_bioinspired290.dll    opencv_highgui290.dll
	AForge.Video.dll       opencv_calib3d290.dll        opencv_imgproc290.dll
	cublas64_55.dll        opencv_contrib290.dll        opencv_legacy290.dll
	cudart64_55.dll        opencv_core290.dll           opencv_ml290.dll
	Cufft64_55.dll         opencv_cudev290.dll          opencv_nonfree290.dll
	cvextern.dll           opencv_features2d290.dll     opencv_objdetect290.dll
	Emgu.CV.dll            opencv_ffmpeg290_64.dll      opencv_ocl290.dll
	Emgu.CV.GPU.dll        opencv_flann290.dll          opencv_optim290.dll
	Emgu.CV.ML.dll         opencv_gpu290.dll            opencv_photo290.dll
	Emgu.CV.OCR.dll        opencv_gpuarithm290.dll      opencv_softcascade290.dll
	Emgu.CV.OpenCL.dll     opencv_gpubgsegm290.dll      opencv_stitching290.dll
	Emgu.CV.Stitching.dll  opencv_gpucodec290.dll       opencv_superres290.dll
	Emgu.CV.UI.dll         opencv_gpufeatures2d290.dll  opencv_video290.dll
	Emgu.CV.VideoStab.dll  opencv_gpufilters290.dll     opencv_videostab290.dll
	Emgu.Util.dll          opencv_gpuimgproc290.dll     ZedGraph.dll
	nppc64_55.dll          opencv_gpulegacy290.dll

You can get these library files from here
-> Aforge .NET libray which contain following file of our project dependencies
	AForge.Controls.dll   
	AForge.dll            
	AForge.Imaging.dll    
	AForge.Math.dll        
	AForge.Video.dll   
LINK-
http://www.aforgenet.com/projects/iplab/downloads.html
			OR
http://code.google.com/p/iplab/downloads/list
			OR
http://iplab.googlecode.com/files/IPLab-2.8.0.exe


-> EMguCV+OpenCV library(Dont need Exact version but we Used 2.4.0) U can Copy These File from the any example folder bin directory Just Copy and Paste all DLL
	nppi64_55.dll                opencv_gpuoptflow290.dll
	npps64_55.dll                opencv_gpustereo290.dll
	OpenCL.dll                   opencv_gpuwarping290.dll
	opencv_bioinspired290.dll    opencv_highgui290.dll
	opencv_calib3d290.dll        opencv_imgproc290.dll
	cublas64_55.dll        opencv_contrib290.dll        opencv_legacy290.dll
	cudart64_55.dll        opencv_core290.dll           opencv_ml290.dll
	Cufft64_55.dll         opencv_cudev290.dll          opencv_nonfree290.dll
	cvextern.dll           opencv_features2d290.dll     opencv_objdetect290.dll
	Emgu.CV.dll            opencv_ffmpeg290_64.dll      opencv_ocl290.dll
	Emgu.CV.GPU.dll        opencv_flann290.dll          opencv_optim290.dll
	Emgu.CV.ML.dll         opencv_gpu290.dll            opencv_photo290.dll
	Emgu.CV.OCR.dll        opencv_gpuarithm290.dll      opencv_softcascade290.dll
	Emgu.CV.OpenCL.dll     opencv_gpubgsegm290.dll      opencv_stitching290.dll
	Emgu.CV.Stitching.dll  opencv_gpucodec290.dll       opencv_superres290.dll
	Emgu.CV.UI.dll         opencv_gpufeatures2d290.dll  opencv_video290.dll
	Emgu.CV.VideoStab.dll  opencv_gpufilters290.dll     opencv_videostab290.dll
	Emgu.Util.dll          opencv_gpuimgproc290.dll     ZedGraph.dll
	nppc64_55.dll          opencv_gpulegacy290.dll
LINK
sourceforge.net/projects/emgucv/

