# Marker-Tracking-Sample

For more info check this post:
http://blog.tarabishi.me/2015/03/marker-based-tracking-sample.html



<div dir="ltr" style="text-align: left;" trbidi="on">
<div dir="ltr" style="text-align: left;" trbidi="on">
<h2 style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><u><b>Marker Based Tracking</b></u></span></span></span></h2>
<div class="separator" style="clear: both; text-align: center;">
<a href="http://3.bp.blogspot.com/-e4sT74TrX1U/VQ65r2KEkmI/AAAAAAAAAeU/A3GKPKWqtaQ/s1600/Tracker%2BSample.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img border="0" src="http://3.bp.blogspot.com/-e4sT74TrX1U/VQ65r2KEkmI/AAAAAAAAAeU/A3GKPKWqtaQ/s1600/Tracker%2BSample.png" height="307" width="640" /></a></div>
<div style="text-align: left;">
<br /></div>
<div style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;">&nbsp;This is a sample project for using <u>Marker based Tracking</u>.</span></span></span></span></div>
<div style="text-align: left;">
<br /></div>
<div style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;"><u>SDK:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b>Metaio</b></span></span></span></span></div>
<div style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;"><u>Render Software:</u>&nbsp; <b>Unity3D</b></span></span></span></span></div>
<div style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;"><u>AI (Unity Plugin):</u>&nbsp;&nbsp; <b>R.A.I.N</b> AI Engine</span></span></span></span></div>
<div style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;"><u>Script Language:</u>&nbsp;&nbsp;&nbsp; <b>C#</b></span></span></span></span></div>
<div style="text-align: left;">
<a href="https://github.com/mamdouht/Marker-Tracking-Sample" style="font-family: 'Comic Sans MS';">Project Files</a><br />
<span style="font-size: large;"><span style="font-size: small;"><br /></span></span>
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;">If you are unfamiliar with Augmented Reality, <a href="http://blog.tarabishi.me/2015/03/microsoft-developers-uae-meetup-6-Augmented-Reality.html">this article </a>could introduce AR to you</span></span></span></span></div>
<div style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;">To Test the sample:<br />-Make sure you have a camera connected to your system, it is preferred if it is not fixed. easier to control.<br />-Make sure to Print the makers from the location:<br />"Asset\StreamingAssets\TrackingSamples" t1.png &amp; t2.png<br /><br />-Open Unity3D with OpenGL Render mode, use the command "Unity.exe -force-opengl"</span></span></span></span></div>
<div style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;"><br />-Scene is in "StreamingAssets\TrackingSamples" Folder Double click on it to open the project<br /><br />-After Opening the Scene:<br />expand MetaioSDK object:<br />you will find two objects with the name "MetaioTracker"<br /><br />if you click on any of them<br />we will see in the inspector<br />"Coordinate System ID"<br />This is the Id number which specify which Marker image is associated with this marker.<br />This information is predefined in the XML File "TrackingData_MarkerlessFast"<br />Located at the same folder as the markers "Asset\StreamingAssets\TrackingSamples" <br /><br />if you expand the "MetaioTracker" objects you will find:<br />in one of them <br />an object called "Max"<br />and in the other one <br />an object called "Tyrant Zombie"<br /><br />Those are the 3D models which they will appear when their parent tracker will detect the associated Marker (pointing the camera to one of the printed markers)</span></span></span></span></div>
<div style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;"></span></span></span></span></div>
<div style="text-align: left;">
<br /></div>
<div style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;">You can alternatively remove those models and add your own.<br /><br />The model "Max" can be controlled with the keyboard: Movement (W,S,A,D)<br />The model "Tyrant Zombie" is associated with an AI system<br />if model "Max" get to his sight range he will start following him<br />if model "Max" get to his attack range he will start attacking him<br />(at this sample no health system is not applied)<br /><br /><u><b>This sample has an issue:</b></u><br /><br />if the "Tyran Zombie" tries to switch his direction it model will be flipped in a weird direction.<br />I am suspecting this is due to the Up Vector and the way it is implemented in the AI engine (R.A.I.N)<br />because AI usually use "transform.LookAt" or "Quaternion.LookRotation" and pass the default UpVector (0,1,0).<br />assuming that UpVector is to parallel to the Y-Axis<br />but with this sample; Metaio SDK will keep changing the position of the markers based on the camera movement so the look stable while we are moving it.<br />Thus UpVector is not (0,1,0) always!<br />I wrote small Script you can find it at this location "Asset/TrackingSamples/AI.CS"<br />and attached to the "Tyrant Zombie" by default it is disabled (because I am using the R.A.I.N engine)<br />The script&nbsp; will make the "Tyrant Zombie" always toward at "Max".<br />In this script I didn't use the Default value for the UpVector but I kept recalculating it for every frame from the Tracker position.<br />so I got more stable movement, and the "Tyrant Zombie" will not flip.<br />&nbsp;</span></span></span></span></div>
<div style="text-align: left;">
<span style="color: #073763;"><span style="font-family: Comic Sans MS;"><span style="font-size: large;"><span style="font-size: small;">To test this script:<br />-expand "Tyrant Zombie" Object and <br />&nbsp;&nbsp;&nbsp; select AI object then disable it (the check box Top-Left at the inspector).<br />-then click on the "Tyrant Zombie" object and<br />&nbsp;&nbsp;&nbsp; click on the check box beside AI script<br /><br />-Note: I used UnityVS add in to make edit and view the code in Visual Studio<br />You may have to go to:"Edit/Preferences" "External Tools" "External Script Editor"<br />to choose your preferred Editor.</span></span></span></span><br />
<br /></div>
</div>

