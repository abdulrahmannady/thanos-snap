# Welcome to Thanos Snap!

this repo for day to day boring tasks it's mainly focus on to make it easy on you while working
I've just created it to delete all screen shot taken to delete it with only **one click**


# Installation 

all you need to do is to download the repo and publish the app into **Executable app** 
after installation  you will get folder inside it you will find **ThanosSnap.exe** and  **appsettings.json** file for configuration open it with notepad
then specify the keys 
**Directory** where the files are 
**FileExtensions** you want to delete it
for example : 

```json
{
	"Directory": "C:\\Users\\{user_name}\\Desktop",

	"FileExtensions": ".jpg,.jpg,.png,.gif"
}
```
after setting the values/keys for both Directory and FileExtensions Run the application by clicking the ThanosSnap.exe

Note: Deleted files will go to _Recycle bin_ not permanently deleted
