# TUGAS BESAR IF2211 - STRATEGI ALGORITMA 2020

## Simulasi Penyebaran Virus Penyakit dengan Memanfaatkan Algoritma BFS untuk Penelusuran pada Graf

Kelompok CirengAntiCorona / K03 :
1. Hengky Surya Angkasa		13518048
2. Naufal Dean Anugrah		13518123
2. Gregorius Jovan Kresnadi 	13518135

## How to build release exe?
1. Open `src/PlagueInc.sln` using Visual Studio in Windows.
2. Change Solution Configurations from Debug to Release.
3. Build solution (Build > Build Solution).
4. The exe file will be generated in `src/PlagueInc/bin/Release`.

## How to run?
### Windows
1. Simply run the `PlagueInc.exe` file inside the `bin` folder. Or you can rebuild the exe file and run it from `src/PlagueInc/bin/Release`.
### Linux
1. Use wine on the exe file inside the `bin` folder.

## How to use the application?
1. Open the application.
2. Input Map and Population manually or using OpenFileDialog (by clicking the `...` button).
3. Input time.
4. Click Calculate button to calculate and show the graph.
5. P.S: You can check the Auto Calc to "automagically" call Calculate after input time is changed.