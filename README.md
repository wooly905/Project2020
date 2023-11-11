# README #

Project 2020: What you see is what you test by computer vision technology

# How this project works #

The idea is simple. You can define the steps to simulate how users operate the software. The steps are a series of mouse and keyboard manipulations. During each step, project2020 will capture the screenshot and send it to some cloud service that supports OCR. Currently, Azure OCR service is supported. In the next release, AWS OCR and GCP OCR will be supported too. The result returned from the cloud service is a set of information that contains characters (including locations of each word) of your screenshot. Project2020 will search the target (text/image) and find the location, so a target can be clicked (mouse) or keystoked (keyboard). This is how one step is done. Project2020 will go through all steps in your JSON file to finish an end-to-end test. 

For more introduction and examples, please see the introduction video at https://youtu.be/7d028QLSBS0 

For the definition of JSON file to test, please refer to WIKI.

# How to use this project #

Download the source code and simply run 

```
>msbuild 2020.sln 
```

in your Visual Studio command prompt. This will generate debug version assemblies which will be in /out/Debug folder. If you need Release configuration, please try the following command and all assemblies will be in .\out\Release folder.

```
>msbuild /p:Configuration=Release 2020.sln
```

After msbuild, you will see Engine.exe and related assemblies in the output folder. 
You can simply run the following code to start a simple test on Notepad.

```
>Engine.exe .\E2EFiles\notepad.json 
```

There are several JSON files under .\E2EFiles for your reference to see what properties we may have in this project to define the test steps.

If you want to run multiple JSON files, you can keep adding the JSON. For example,

```
>Engine.exe .\E2EFiles\notepad.json .\test1.json .\test2.json
```

Currently, the source code only supports Windows OS. For other OS, there exists a plan but no ETA.

# License #

It's BSD-3. If you have some concerns, please let me know.
