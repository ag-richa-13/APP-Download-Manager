# APP-Download-Manager

## In-App Updates: Unity & Custom Android Library
This project demonstrates how to integrate an Android library for downloading and installing APK files programmatically from within a Unity application.

### Getting Started
These instructions will help you integrate the Android library into your Unity project and use it to download and install APK files.

#### Prerequisites
<ul>
  <li>Unity</li>
  <li>Android Studio (for building the Android library)</li>
</ul>

#### Installing

<ol>
  <li><h5>Clone the repository or download the source code.</h5></li>
  <li><h5>Integrate the Android Library:</h5>
   <ul>
     <li>Locate the .aar file of your Android library that handles APK download and installation.</li>
     <li>Copy the .aar file into the Plugins/Android directory of your Unity project.</li>
   </ul>
  </li>
  <li><h5>Configure Unity Project:</h5>
   <ul>
     <li>Open your Unity project.</li>
     <li>Set the <mark> Minimum API Level </mark>  under <mark> Edit -> Project Settings -> Player </mark>  to match the requirements of your Android library.</li>
     <li>Configure other Android publishing settings as needed.</li>
   </ul>
  </li>
  <li><h5>Access the Android Library from Unity:</h5>
   <ul>
     <li>Attach the provided C# script (DownloadManager.cs) to a GameObject in your Unity scene.</li>
     <li>Call the OnClickDownloadButton() method from your Unity scripts to initiate APK download and installation.</li>
   </ul>
  </li>
</ul>

### Built With
<ul>
  <li>Unity - Game development engine</li>
  <li>Android Studio - For building the Android library</li>
</ul>

### Checkout my Blogs

[![Medium](https://img.shields.io/badge/Medium-000000?style=for-the-badge&logo=medium&logoColor=white&labelColor=000000&color=000000&shape=round)](https://agricha-13.medium.com/)

### Connect with Us

Follow me on social media to stay updated!

[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white&labelColor=181717&color=181717)](https://github.com/ag-richa-13)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white&labelColor=0077B5&color=0077B5)](https://www.linkedin.com/in/ag-richa-13s/)
[![Twitter](https://img.shields.io/badge/Twitter-000000?style=for-the-badge&logo=x&logoColor=white&labelColor=000000&color=000000)](https://x.com/IMRichaAgrawal)
[![Instagram](https://img.shields.io/badge/Instagram-E4405F?style=for-the-badge&logo=instagram&logoColor=white&labelColor=E4405F&color=E4405F)](https://www.instagram.com/r.i._c_.h.a/)

