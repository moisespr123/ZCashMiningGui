# ZCashMiningGui
A ZCash Mining GUI for nheqminer. Tested with Nicehash nheqminer Windows build.

This software is written in Visual Basic .NET using Visual Studio 2015.

To use it, you must first download "nheqminer" and place the executable "nheqminer.exe" and all of the nheqminer files inside a folder called "nheqminer" which should be created in the same folder where you download the ZCash Mining GUI. The software will lead you to the github repo for the Nicehash nheqminer releases so you can download it and start mining, or you can download it from here: https://github.com/nicehash/nheqminer/releases

To mine ZCash, just fill out the details and press the "Start Mining!" button. After that, you will see your mining progress in the Miner Output section. It may not be realtime, but it will display the progress.

You can minimize the GUI and it will keep mining in the System Tray. Double click it to show the software.

That's all. Enjoy!

# Changelog
v0.3 (11/4/2016) </br>
-Added Stop Mining button </br>
-Performance improvements

v0.2b (11/4/2016)</br>
-Fixed Threads and Blocks not being set to default values when Threads and Blocks are set to 0 in the Tuning Window</br>
-Added a message in the Tuning Window that 0 means default values

v0.2 (11/4/2016)</br>
-Added Compatibility Mode for Nvidia cards (-cv 1)</br>
-Added Threads and Blocks tuning for Nvidia cards (-ct and -cb)</br>
-Now using the nheqminer.exe executable</br>
-EU and USA server option removed in favor for a user-specified server and port. Currently defaults to Nicehash ZCash pool

v0.1</br>
-Initial Releas
