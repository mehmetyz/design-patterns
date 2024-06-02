
using DesignPatterns.Factory;

OperatingSystemManager personalSystemManager = new PersonalOperatingSystemManager();
OperatingSystemManager serverSystemManager = new ServerOperatingSystemManager();

personalSystemManager.InstallOperatingSystem("Linux");
personalSystemManager.InstallOperatingSystem("Windows");
serverSystemManager.InstallOperatingSystem("Macos");
