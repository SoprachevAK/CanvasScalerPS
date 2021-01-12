## Quick Package Install

#### Using UnityPackageManager (for Unity 2019.3 or later)
Open the package manager window (menu: Window > Package Manager)<br/>
Select "Add package from git URL...", fill in the pop-up with the following link:<br/>
https://github.com/coryleach/UnityPackages.git#1.0.2<br/>

#### Using UnityPackageManager (for Unity 2019.1 or later)

Find the manifest.json file in the Packages folder of your project and edit it to look like this:
```js
{
  "dependencies": {
    "com.gameframe.packages": "https://github.com/coryleach/UnityPackages.git#1.0.2",
    ...
  },
}
```

<!-- DOC-START -->
<!-- 
Changes between 'DOC START' and 'DOC END' will not be lost on package update 
-->

## Usage

Open the window using the gameframe menu.

Gameframe->Packages->Maintain
The maintain tab displays and allows you to edit package manifest details
It also has a button for updating the README file.

Gameframe->Packages->Create
The create tab is used for creating new packages.
You can create packages either embeded in the Unity project or in the chosen source directory.

Gameframe->Packages->Embed
The embed tap will scan the source directory for packages.
Clicking the 'embed' button on a package will create a softlink to the package in the project's Packages folder.

<!-- DOC-END -->

## Author

**Soprachev Andrei**


## Show your support

Give a ⭐️ if this project helped you!