Custom WoW Launcher
========================
World of Warcraft game launcher that provides some useful features for modders of older versions of the game.

Technologies used
--------------
- WinForms
- C# 5
- .NET Framework 4.5

# Features
The launcher contains an very simple update mechanism that supports connecting to a webserver to gather version information and self update and/or download MPQ (WoW MoPaQ) patches.

###  Gathering updates information
 The launcher will check if a file named `update.xml` exists in the same directory, otherwise it will attempt to connect to a web server with a given IP address or domain (declared as [`remoteHost`](Updater.cs#L58)) and will read an XML file from `[host]/update.xml` which should contain information about different components supported by the update mechanism. An example `update.xml` can be found at the bottom of this document.
 Currently there are 3 supported components: 
 - `wow` - contains metadata (MD5, link) about the latest version of the game executable
 - `launcher` - contains metadata (MD5, version, link) about the latest version of the launcher
 - `patch` - contains metadata (MD5, filename, link) about the latest version of a patch
 ### Checking validty of XML
 The update system will check if the gathered information follows some simple rules, thus is valid. The requirements for the `update.xml` to count as valid are the following:
 - Root element with an arbitrary name MUST have an attribute named `base` which will point to the address 
that will host the updated files. This allows a level of decoupling the host that contains `update.xml` and the host that contains executables and patches.
- There must be either one or zero `wow` components; same goes for `launcher` component.
- All `link` attributes CAN contain `$BASE` (which points to the `base` attribute of the root)
- `wow` component must contain (if it exists) the following attributes `md5`, `link`.
- `launcher` component must contain (if it exists) the following attributes `md5`, `version`, `link`
- There can be ANY number of `patch` components as long as the `file` attribute's value is unique.
### Self updating
If there's a new launcher update, the system will add an `.old` extension the current running executable and then it will download the new launcher. If the md5 checks, the new launcher is launched and the current process exists.

**Note**: If the MD5 check fails, the downloaded launcher will be deleted and the current executable will be renamed to it's original name.
### Game detection

After checking for updates (and updating itself if necessary), the launcher will try to delete the old launcher (if there's any) and then move to the main phase. If it detects a valid WoW game folder and the locale (only `enGB` and `enUS` are supported) , it will continue to the main menu, otherwise it will exit with an error message.

### Updating the realmlist
The next step the launcher will take is deleting the `Cache` folder which contains data cached by the game. This is a very useful feature for modders as deleting the `Cache` folder is required every time after editing stuff ingame. Even when not editing, deleting the `Cache` is always recommended. Following that, the launcher will edit the `realmlist.wtf` which contains the game server address or IP and it will replace it with `localhost` or any other value specified inside the source.

### Downloading or updating patches
As most client side edits require an MPQ patch, this launcher facilitates the distribution of patches through it quite easily. In this final phase, the metadata parsed from `update.xml` will be compared to current metadata of downloaded patches (if any) and if any of the patches are not up-to-date, the launcher will download and replace the MPQ archive with a newer one. The progress bar will update based on download progress. After all the patches have been download or updated, the Play button will become active.

# Example `update.xml`
```xml
<?xml version="1.0" encoding="UTF-8">
<update base="mydomain.org/">
  <component name="wow" md5="d722dbcb93d6ca952b49928b37cac8e1" link="$BASE/wow.exe"/>
  <component name="launcher" md5="f3e08b5119358a8f58f17a678759f60c" version="" link="$BASE/launcher.exe">
  <component name="patch" md5="9fe63121ee336ae7c4e9919b8754d630" file="patch-X.mpq" link="$BASE/patches/X.mpq">
</update>
```
# License
This project is licensed under the [MIT](https://en.wikipedia.org/wiki/MIT_License) license. See [LICENSE](LICENSE)