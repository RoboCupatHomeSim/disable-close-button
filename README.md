# Disable Close Button
This is an application that disables the close button.

This application is for RoboCup administrators. It is not for the participants.


## Prerequisites

- Windows 10 or Windows Server 2019
- Visual Studio 2019 (.NETFramework v4.7.2)


## How to Build

1. Launch Visual Studio.
1. Open the DisableCloseButton.sln with Visual Studio.
1. Click [Build]-[Build Solution].
1. DisableCloseButton.exe is generated in a "DisableCloseButton\bin\Release" folder.

## How to Execute

1. Launch a command prompt.
1. For example, in the case of Notepad, set the window name as the first argument and execute a command like the following:
```
> cd DisableCloseButton\bin\Release
> DisableCloseButton "TestDoc.txt - Notepad"
```
1. Please use the Task Manager to close the window.


## License

This project is licensed under the MIT License - see the LICENSE file for details.
